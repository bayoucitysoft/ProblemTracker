using ProblemTracker.Commands;
using ProblemTracker.Database;
using ProblemTracker.Helper;
using ProblemTracker.Models;
using ProblemTracker.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;


namespace ProblemTracker.ViewModels
{
    public class EntryViewModel : BaseViewModel
    {
        #region EntryViewModelProperties
        public Frame Navigation { get; set; }

        public bool IsCreate { get; set; }

        public string AutoCompleter
        {
            get { return model.AutoCompleter; }
            set
            {
                model.AutoCompleter = value;
                OnPropertyChanged("AutoCompleter");
            }
        }

        public Entry model;
        public string Name
        {
            get { return model.Name; }
            set
            {
                model.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public DateTime DateCompleted
        {
            get { return model.DateCompleted; }
            set 
            { 
                model.DateCompleted = value; 
                OnPropertyChanged("DateCompleted"); 
            }
        }

        public string Comment
        { 
            get { return model.Comment; } 
            set 
            { 
                model.Comment = value;
                OnPropertyChanged("Comment");
            } 
        }
        public string Header
        {
            get { return model.Header; }
            set
            {
                model.Header = value;
                OnPropertyChanged("Header");
            }
        }

        private Entry selectedEntry;
        public Entry SelectedEntry
        {
            get { return selectedEntry; }
            set
            {
                selectedEntry = value;
                OnPropertyChanged("SelectedEntry");
            }

        }
        private EntryDisplay selectedItem;
        public EntryDisplay SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
                if (selectedItem != null)
                    SelectedEntry = EntryCollection.Single(x => x.Id == SelectedItem.Id) as Entry;
                Comment = SelectedEntry.Comment;
                Header = SelectedEntry.Header;
                NavigateSelection(SelectedItem);
            }
        }
        public List<Entry> EntryCollection;

        private ObservableCollection<EntryDisplay> entryDisplayCollection;
        private EntryViewModel entryViewModel;
        public ObservableCollection<EntryDisplay> EntryDisplayCollection
        {
            get { return entryDisplayCollection; }
            set
            {
                entryDisplayCollection = value;
                OnPropertyChanged("EntryDisplay");
            }
        }
        #endregion

        #region Constructor
        public EntryViewModel(bool create, Frame main)
        {
            Navigation = main;
            if (create)
            {
                this.IsCreate = create;
                model = new Entry();
                EntryCollection = new List<Entry>();
                EntryDisplayCollection = new ObservableCollection<EntryDisplay>();

                AddCommand = new AddCommand(this);
                ModifyCommand = new ModifyCommand(this);
                RemoveCommand = new RemoveCommand(this);
                ClearCommand = new ClearCommand(this);
                ReportCommand = new ReportCommand(this);
               
            }
            else
            {
                this.IsCreate = false;
                model = new Entry();
                EntryDisplayCollection = new ObservableCollection<EntryDisplay>();
                EntryCollection = model.GetHeaders();
                if (EntryCollection.Count > 0)
                {
                    foreach (Entry e in EntryCollection)
                    {
                        EntryDisplay _entryDisplay = new EntryDisplay(e.DateCompleted.ToString("MM/dd/yyyy HH:mm"), e.Header, e.Id);
                        EntryDisplayCollection.Add(_entryDisplay);

                        AddCommand = new AddCommand(this);
                        RemoveCommand = new RemoveCommand(this);
                        SearchCommand = new SearchCommand(this);
                        ClearCommand = new ClearCommand(this);
                        ReportCommand = new ReportCommand(this);
                    }
                }
                else
                {
                    EntryCollection = new List<Entry>();
                    EntryDisplayCollection = new ObservableCollection<EntryDisplay>();
                    
                    AddCommand = new AddCommand(this);
                    RemoveCommand = new RemoveCommand(this);
                    SearchCommand = new SearchCommand(this);
                    ClearCommand = new ClearCommand(this);
                    ReportCommand = new ReportCommand(this);
                }
            }
        }

        public EntryViewModel(EntryViewModel entryViewModel)
        {
            SelectedItem = entryViewModel.SelectedItem;
        }
        #endregion

        #region ViewModelFunctions
        internal void NavigateSelection(EntryDisplay selection)
        {
            if (!this.IsCreate)
            {
                Entry nav = new Entry();
                foreach (var entry in EntryCollection)
                    if (entry.Id == SelectedItem.Id)
                        nav = entry;
                SQLAccess.Clear();
                SQLAccess.Procedure = "EntryCollectionByParentId";
                SQLAccess.Parameters.Add(@"@parentId", nav.ParentId);
                DataTable _entryCollection = SQLAccess.ExecuteProcedure();

                GenerateEntrCollectionyFromDataTable(_entryCollection);
                GenerateDisplayCollection(EntryCollection);
                Navigation.NavigationService.Navigate(new NewEntryView(Navigation, this));
                IsCreate = true;
            }
            else
            {
                Entry selected = new Entry();
                foreach (var entry in EntryCollection)
                {
                    
                       
                }
            }
        }

       

        private void GenerateDisplayCollection(List<Entry> EntryCollection)
        {
            this.EntryDisplayCollection.Clear();
            foreach (var entry in EntryCollection)
            {
                EntryDisplay tmp = new EntryDisplay(entry.DateCompleted.ToString("MM/dd/yyyy HH:mm"), entry.Header, entry.Id);
                this.EntryDisplayCollection.Add(tmp);
            }
        }

        internal void Add()
        {
            if(string.IsNullOrEmpty(Name))
                Name = Header;

            string _header = Header;
            string _parentId = string.Empty;
            string _name = string.Empty;
            string _comment = Comment;
         
            DateTime _dateCompleted = DateTime.Now;
            DateCompleted = _dateCompleted;
            Entry tmp = null;
            EntryDisplay tmpDisplay = null;
            if (EntryCollection.Count > 0)
            {
                Header = EntryCollection[0].Header;
                _parentId = EntryCollection[0].ParentId;
                _name = EntryCollection[0].Name;
                tmp = new Entry(_name, _dateCompleted, _header, _comment, _parentId, Guid.NewGuid().ToString());
                tmpDisplay = new EntryDisplay(_dateCompleted.ToString("MM/dd/yyyy HH:mm"), FormatHeader(_header), tmp.Id);
            }
            else
            {
                tmp = new Entry(Name, _dateCompleted, _header, _comment, model.ParentId, Guid.NewGuid().ToString());
                tmpDisplay = new EntryDisplay(_dateCompleted.ToString("MM/dd/yyyy HH:mm"), FormatHeader(_header), tmp.Id);
            }
            
           
            EntryDisplayCollection.Add(tmpDisplay);
            EntryCollection.Add(tmp);

            foreach (var entry in EntryCollection)
            {
                SQLAccess.Clear();
                SQLAccess.Procedure = "CreateEntry";
                SQLAccess.Parameters.Add(@"@name", entry.Name);
                SQLAccess.Parameters.Add(@"@header", entry.Header);
                SQLAccess.Parameters.Add(@"@comment", entry.Comment);
                SQLAccess.Parameters.Add(@"@dateCompleted", entry.DateCompleted);
                SQLAccess.Parameters.Add(@"@parentId", entry.ParentId);
                SQLAccess.Parameters.Add(@"@id", entry.Id);
                SQLAccess.Execute();
            }
            
            Clear();
        }

        public void Remove()
        {
            var _display = EntryDisplayCollection.Single(x => x.Completed == SelectedItem.Completed) as EntryDisplay;
            Entry _entry = EntryCollection.Single(x => x.Id == SelectedItem.Id) as Entry;
            EntryDisplayCollection.Remove(_display);
            EntryCollection.Remove(_entry);
            SelectedItem = null;
            //Add Removal logic to sql call 
            SQLAccess.Clear();
            SQLAccess.Procedure = "RemoveEntry";
            SQLAccess.Parameters.Add(@"@id", _entry.Id);
            SQLAccess.Execute();
            Clear();
        }

        public void Report()
        {
            Report report = new Report(EntryCollection);
        }

        public void Search()
        {
            if (!string.IsNullOrEmpty(AutoCompleter))
            {
                if (entryDisplayCollection.Any(x => x.Header.Contains(AutoCompleter)))
                {
                    var results = EntryDisplayCollection.Where(x => x.Header.Contains(AutoCompleter)).ToList();
                    EntryDisplayCollection.Clear();
                    foreach (var result in results)
                        EntryDisplayCollection.Add(result);
                }
            }
        }

        public void Clear()
        {
            Header = string.Empty;
            Comment = string.Empty;
        }

        private List<Entry> GenerateEntrCollectionyFromDataTable(DataTable _entryCollection)
        {
            EntryCollection.Clear();
            List<Entry> response = new List<Entry>();
            foreach (DataRow row in _entryCollection.Rows)
            {
                Entry tmp = new Entry(Convert.ToString(row["Name"]),
                    Convert.ToDateTime(row["DateCompleted"]),
                    Convert.ToString(row["Header"]),
                    Convert.ToString(row["Comment"]),
                    Convert.ToString(row["ParentId"]),
                    Convert.ToString(row["Id"]));
                EntryCollection.Add(tmp);
            }
            return response;
        }

        private string FormatHeader(string header)
        {
            string tmp = string.Empty;
            if (!String.IsNullOrEmpty(header))
            {
                if (header.Count() >= 30)
                {
                    char[] _header = header.ToArray();
                    for (int i = 0; i < 30; i++)
                        tmp += _header[i].ToString();
                    tmp = tmp + "...";
                }
                else
                    tmp = header;
            }
            else
                tmp = header;
            return tmp;
        }
        #endregion
    }
}
