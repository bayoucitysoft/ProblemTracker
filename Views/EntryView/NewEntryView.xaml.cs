using ProblemTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProblemTracker.Views
{
    /// <summary>
    /// Interaction logic for NewEntryView.xaml
    /// </summary>
    public partial class NewEntryView : Page
    {
        public NewEntryView(Frame main)
        {
            InitializeComponent();
            this.DataContext = new EntryViewModel(true, main);
        }

        public NewEntryView(Frame Navigation, EntryViewModel entryViewModel)
        {
            InitializeComponent();
            this.DataContext = entryViewModel;
        }
    }
}
