using ProblemTracker.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTracker.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }
        public DateTime SelectedDate { get; set; }

        public bool CanAdd = true;
        public bool CanRemove = true;
        public bool CanSubmit = true;

        public AddCommand AddCommand { get; set; }
        public ModifyCommand ModifyCommand { get; set; }
        public ClearCommand ClearCommand { get; set; }
        public RemoveCommand RemoveCommand { get; set; }
        public SubmitCommand SubmitCommand { get; set; }
        public SelectCommand SelectCommand { get; set; }
        public ViewCommand ViewCommand { get; set; }
        public SearchCommand SearchCommand { get; set; }
        public ReportCommand ReportCommand { get; set; } 
    }

    

}
