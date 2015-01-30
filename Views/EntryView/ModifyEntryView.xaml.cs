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
    /// Interaction logic for ModifyEntryView.xaml
    /// </summary>
    public partial class ModifyEntryView : Page
    {
        private Frame MainPanel;

        public ModifyEntryView()
        {
  
        }

        public ModifyEntryView(Frame MainPanel)
        {
            InitializeComponent();
            DataContext = new EntryViewModel(false, MainPanel);
        }
    }
}
