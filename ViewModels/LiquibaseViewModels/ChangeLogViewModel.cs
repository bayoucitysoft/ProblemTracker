using ProblemTracker.Models.LiquibaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemTracker.Commands;
using System.Windows.Controls;
using ProblemTracker.Helper;
using System.Windows;
using System.Xml;

namespace ProblemTracker.ViewModels.LiquibaseViewModels
{
    public class ChangeLogViewModel : BaseViewModel
    {
        public ChangeLog Log;
        public ChangeSet ChangeSet;

        private TreeView tree;
        public TreeView Tree
        {
            get { return tree; }
            set { tree = value; OnPropertyChanged("Tree"); }
        }

        private string input;
        public string Input
        {
            get { return input; }
            set { input = value; OnPropertyChanged("Input"); }
        }

        private string output;
        public string Output
        {
            get { return output; }
            set { output = value; OnPropertyChanged("Output"); }
        }

        private string path;
        public string Path
        {
            get { return path; }
            set { path = value; OnPropertyChanged("Path"); }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; OnPropertyChanged("Author"); }
        }

        private string identifier;
        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; OnPropertyChanged("Identifier"); }
        }

        private string nodeSelection;
        public string NodeSelection
        {
            get { return nodeSelection; }
            set { nodeSelection = value; OnPropertyChanged("DropDownSelection"); }
        }

        public List<string> Nodes { get; set; }

        public ChangeLogViewModel()
        {
            //tmp just for testing 
            Tree = new TreeView();
            Path = @"C:\vsprojects\Ensco_TRUNK\Database\instance-changelog.xml";
            Output = "Press 'Select' to generate Tree View.";
            Author = "Author";
            Nodes = GenerateSelectableNodes();

            this.AddCommand = new AddCommand(this);
            this.ClearCommand = new ClearCommand(this);
            this.SelectCommand = new SelectCommand(this);
            this.RemoveCommand = new RemoveCommand(this);
            this.SubmitCommand = new SubmitCommand(this);
            this.ViewCommand = new ViewCommand(this);
        }

        public void Select()
        {
            if (String.IsNullOrEmpty(Path))
            {
                Output = "Invalid Path.";
            }
            else
            {
                Output = "Select an item from the TreeView and click 'View' to observe contents.";
                Log = XMLHelper.ObjectFromPath(Path);
                var _Log = XMLHelper.Properties(Path);
                foreach(var set in Log.ChangeSets)
                {
                    Tree.Items.Add(GenerateTreeViewItems(set));
                }
                OnPropertyChanged("Tree");
            }
        }

        internal void Add()
        {
            bool errors = false;
            Output = string.Empty;
            if (string.IsNullOrEmpty(Input))
            {
                Output = " Cannot create a blank entry. ";
                errors = true;
            }
            if (string.IsNullOrEmpty(Author) || Author == "Author")
            {
                Output += "Please specify an Author. ";
                errors = true;
            }
            if (string.IsNullOrEmpty(NodeSelection))
            {
                Output += "Please select a node. ";
                errors = true;
            }
            if (string.IsNullOrEmpty(Path))
            {
                Output += "Please specify a filepath. ";
                errors = true;
            }
            if (!errors)
            {
                ChangeSet changeSet = new ChangeSet();
                changeSet.Author= Author;
                changeSet.Id = GenerateId(Author);
                if (NodeSelection == "<sql>")
                {
                    changeSet.Sql.Add(Input);
                }
                ChangeSet = changeSet;
                Input = XMLHelper.Seralize(changeSet, Path);
            }
            else
            {
                Output = Output.Insert(0, "ERRORS: ");
            }
                
        }

        internal void Submit()
        {
            if(!string.IsNullOrEmpty(Input))
            {
                if (ChangeSet != null)
                    Log.ChangeSets.Add(ChangeSet);

                XMLHelper.Save(Log, Path);
            }
        }

        internal void View()
        {
            if (Tree.SelectedItem != null)
            {
                TreeViewItem item = (TreeViewItem)Tree.SelectedItem;
                ChangeSet selectedItem = new ChangeSet();
                if (item.Parent != null)
                {
                    TreeViewItem parent = (TreeViewItem)item.Parent;
                    Output = String.Format(" {0} | {1}", parent.Header.ToString(), item.Header.ToString());

                    selectedItem = Log.ChangeSets.Where(s => s.Id == parent.Header.ToString()).First();
                    Input = SelectedProperties(selectedItem, item.Header.ToString());
                    Author = selectedItem.Author;
                    Identifier = selectedItem.Id;
                }             
            }
        }

        internal void Clear()
        {
            Author = string.Empty;
            Identifier = string.Empty;
            Output = string.Empty;
            Input = string.Empty;
        }


        private string GenerateId(string Author)
        {
            string response = Author.ToLower().Replace(" ", string.Empty);
            response += "-" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            response += "-" + Guid.NewGuid().ToString().ToUpper();
            return response; 
        }

        private string SelectedProperties(ChangeSet selectedItem, string p)
        {
            string response = string.Empty;
            p = p.TrimStart('<');
            p = p.TrimEnd('>');

            if (selectedItem.Sql != null && p == "sql")
            {
                foreach (var s in selectedItem.Sql)
                {
                    string stripper = TrimTheBush(s);
                    response += stripper;

                }
            }

            return response;
        }

        private string TrimTheBush(string _s)
        {
            string response = string.Empty;
            if (!string.IsNullOrEmpty(_s))
            {
                char[] arr = _s.ToCharArray();
                for (int i = 0; i < 5; i++)
                {
                    if (arr[i] == 10 || arr[i] == 9)
                        arr[i] = ' ';
                }
                response = new string(arr);
            }
            return response;
        }



        private TreeViewItem GenerateTreeViewItems(ChangeSet set)
        {
            TreeViewItem response = new TreeViewItem();
            response.Header = set.Id;
            //if (set.validCheckSum != null)
            //{
            //    response.Items.Add("<validCheckSum>");            
            //}
            //if (set.preConditions != null)
            //{
            //    TreeViewItem precon = new TreeViewItem();
            //    precon.Header = "<preConditions>";
            //    response.Items.Add(precon);
            //}
            //if (set.tagDatabase != null)
            //{
            //    TreeViewItem tagDatabase = new TreeViewItem();
            //    tagDatabase.Header = "<tagDatabase>";
            //    response.Items.Add(tagDatabase);
            //}
            //if (set.createTable != null)
            //{
            //    TreeViewItem createTable = new TreeViewItem();
            //    createTable.Header = "<createTable>";
            //    response.Items.Add(createTable);
            //}
            //if (set.dropTable != null)
            //{
            //    TreeViewItem dropTable = new TreeViewItem();
            //    dropTable.Header = "<dropTable>";
            //    response.Items.Add(dropTable);
            //}
            //if (set.createView != null)
            //{
            //    TreeViewItem createView = new TreeViewItem();
            //    createView.Header = "<createView>";
            //    response.Items.Add(createView);
            //}
            //if (set.renameView != null)
            //{
            //    TreeViewItem renameView = new TreeViewItem();
            //    renameView.Header = "<renameView>";
            //    response.Items.Add(renameView);
            //}
            //if (set.dropView != null)
            //{
            //    TreeViewItem dropView = new TreeViewItem();
            //    dropView.Header = "<dropView>";
            //    response.Items.Add(dropView);
            //}
            //if (set.insert != null)
            //{
            //    TreeViewItem insert = new TreeViewItem();
            //    insert.Header = "<insert>";
            //    response.Items.Add(insert);
            //}
            //if (set.addColumn != null)
            //{
            //    TreeViewItem addColumn = new TreeViewItem();
            //    addColumn.Header = "<addColumn>";
            //    response.Items.Add(addColumn);
            //}
            //if (set.createProcedure != null)
            //{
            //    TreeViewItem createProceure = new TreeViewItem();
            //    createProceure.Header = "<createProcedure>";
            //    response.Items.Add(createProceure);
            //}
            //if (set.sqlFile != null)
            //{
            //    TreeViewItem sqlFile = new TreeViewItem();
            //    sqlFile.Header = "<sqlFile>";
            //    response.Items.Add(sqlFile);
            //}
            //if (set.renameTable != null)
            //{
            //    TreeViewItem renameTable = new TreeViewItem();
            //    renameTable.Header = "<renameTable>";
            //    response.Items.Add(renameTable);
            //}
            //if (set.renameColumn != null)
            //{
            //    TreeViewItem renameColumn = new TreeViewItem();
            //    renameColumn.Header = "<renameColumn>";
            //    response.Items.Add(renameColumn);
            //}
            //if (set.dropColumn != null)
            //{
            //    TreeViewItem dropColumn = new TreeViewItem();
            //    dropColumn.Header = "<dropColumn>";
            //    response.Items.Add(dropColumn);
            //}
            //if (set.modifyColumn != null)
            //{
            //    TreeViewItem modifyColumn = new TreeViewItem();
            //    modifyColumn.Header = "<modifyColumn>";
            //    response.Items.Add(modifyColumn);
            //}
            //if (set.mergeColumns != null)
            //{
            //    TreeViewItem mergeColumns = new TreeViewItem();
            //    mergeColumns.Header = "<mergeColumns>";
            //    response.Items.Add(mergeColumns);
            //}
            //if (set.createSequence != null)
            //{
            //    TreeViewItem createSequence = new TreeViewItem();
            //    createSequence.Header = "<createSequence>";
            //    response.Items.Add(createSequence);
            //}
            //if (set.alterSequence != null)
            //{
            //    TreeViewItem alterSequence = new TreeViewItem();
            //    alterSequence.Header = "<alterSequence>";
            //    response.Items.Add(alterSequence);
            //}
            //if (set.dropSequence != null)
            //{
            //    TreeViewItem dropSequence = new TreeViewItem();
            //    dropSequence.Header = "<dropSequence>";
            //    response.Items.Add(dropSequence);
            //}
            //if (set.createIndex != null)
            //{
            //    TreeViewItem createIndex = new TreeViewItem();
            //    createIndex.Header = "<createIndex>";
            //    response.Items.Add(createIndex);
            //}
            //if (set.dropIndex != null)
            //{
            //    TreeViewItem dropIndex = new TreeViewItem();
            //    dropIndex.Header = "<dropIndex>";
            //    response.Items.Add(dropIndex);
            //}
            //if (set.addNotNullConstraint != null)
            //{
            //    TreeViewItem addNotNullConstraint = new TreeViewItem();
            //    addNotNullConstraint.Header = "<addNotNullConstraint>";
            //    response.Items.Add(addNotNullConstraint);
            //}
            //if (set.dropNotNullConstraint != null)
            //{
            //    TreeViewItem dropNotNullConstraint = new TreeViewItem();
            //    dropNotNullConstraint.Header = "<dropNotNullConstraint>";
            //    response.Items.Add(dropNotNullConstraint);
            //}
            //if (set.dropAllForeignKeyConstraints != null)
            //{
            //    TreeViewItem dropAllForeignKeyConstraints = new TreeViewItem();
            //    dropAllForeignKeyConstraints.Header = "<dropAllForeignKeyConstraints>";
            //    response.Items.Add(dropAllForeignKeyConstraints);
            //}
            //if (set.addPrimaryKey != null)
            //{
            //    TreeViewItem addPrimaryKey = new TreeViewItem();
            //    addPrimaryKey.Header = "<addPrimaryKey>";
            //    response.Items.Add(addPrimaryKey);
            //}
            //if (set.dropPrimaryKey != null)
            //{
            //    TreeViewItem dropPrimaryKey = new TreeViewItem();
            //    dropPrimaryKey.Header = "<dropPrimaryKey>";
            //    response.Items.Add(dropPrimaryKey);
            //}
            //if (set.addLookupTable != null)
            //{
            //    TreeViewItem addLookupTable = new TreeViewItem();
            //    addLookupTable.Header = "<addLookupTable>";
            //    response.Items.Add(addLookupTable);
            //}
            //if (set.addAutoIncrement != null)
            //{
            //    TreeViewItem addAutoIncrement = new TreeViewItem();
            //    addAutoIncrement.Header = "<addAutoIncrement>";
            //    response.Items.Add(addAutoIncrement);
            //}
            //if (set.addDefaultValue != null)
            //{
            //    TreeViewItem addDefaultValue = new TreeViewItem();
            //    addDefaultValue.Header = "<addDefaultValue>";
            //    response.Items.Add(addDefaultValue);
            //}
            //if (set.dropDefaultValue != null)
            //{
            //    TreeViewItem dropDefaultValue = new TreeViewItem();
            //    dropDefaultValue.Header = "<dropDefaultVaulue>";
            //    response.Items.Add(dropDefaultValue);
            //}
            //if (set.addUniqueConstraint != null)
            //{
            //    TreeViewItem addUniqueConstraint = new TreeViewItem();
            //    addUniqueConstraint.Header = "<addUniqueConstraint>";
            //    response.Items.Add(addUniqueConstraint);
            //}
            //if (set.dropUniqueConstraint != null)
            //{
            //    TreeViewItem dropUniqueConstraint = new TreeViewItem();
            //    dropUniqueConstraint.Header = "<dropUniqueConstraint>";
            //    response.Items.Add(dropUniqueConstraint);
            //}
            //if (set.customChange != null)
            //{
            //    TreeViewItem customChange = new TreeViewItem();
            //    customChange.Header = "<customChange>";
            //    response.Items.Add(customChange);
            //}
            //if (set.update != null)
            //{
            //    TreeViewItem update = new TreeViewItem();
            //    update.Header = "<update>";
            //    response.Items.Add(update);
            //}
            //if (set.delete != null)
            //{
            //    TreeViewItem delete = new TreeViewItem();
            //    delete.Header = "<delete>";
            //    response.Items.Add(delete);
            //}
            //if (set.loadData != null)
            //{
            //    TreeViewItem loadData = new TreeViewItem();
            //    loadData.Header = "<loadData>";
            //    response.Items.Add(loadData);
            //}
            //if (set.executeCommand != null)
            //{
            //    TreeViewItem executeCommand = new TreeViewItem();
            //    executeCommand.Header = "<executeCommand>";
            //    response.Items.Add(executeCommand);
            //}
            //if (set.stop != null)
            //{
            //    TreeViewItem stop = new TreeViewItem();
            //    stop.Header = "<stop>";
            //    response.Items.Add(stop);
            //}
            //if (set.rollback != null)
            //{
            //    TreeViewItem rollback = new TreeViewItem();
            //    rollback.Header = "<rollback>";
            //    response.Items.Add(rollback);
            //}
            //if (set.modifySql != null)
            //{
            //    TreeViewItem modifySql = new TreeViewItem();
            //    modifySql.Header = "<modifySql>";
            //    response.Items.Add(modifySql);
            //}
            //if (set.addForeignKeyConstraint != null)
            //{
            //    TreeViewItem addForeignKeyConstraint = new TreeViewItem();
            //    addForeignKeyConstraint.Header = "<addForeignKeyConstraint>";
            //    response.Items.Add(addForeignKeyConstraint);
            //}
            //if (set.dropForeignKeyConstraint != null)
            //{
            //    TreeViewItem dropForeignKeyConstraint = new TreeViewItem();
            //    dropForeignKeyConstraint.Header = "<dropForeignKeyConstraint>";
            //    response.Items.Add(dropForeignKeyConstraint);
            //}
            if (set.Sql != null)
            {
                foreach (var _sql in set.Sql)
                {
                    TreeViewItem sql = new TreeViewItem();
                    sql.Header = "<sql>";
                    response.Items.Add(sql);
                }
            }
            return response;
        }
        private List<string> GenerateSelectableNodes()
        {
            List<string> nodeList = new List<string>();
            nodeList.Add("<preConditions>");
            nodeList.Add("<sql>");

            return nodeList;
        }

    }
}

