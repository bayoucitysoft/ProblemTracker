using ProblemTracker.ViewModels.LiquibaseViewModels;
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

namespace ProblemTracker.Views.LiquibaseViews
{
    /// <summary>
    /// Interaction logic for LiquibaseAddView.xaml
    /// </summary>
    public partial class LiquibaseAddView : Page
    {
        public LiquibaseAddView()
        {
            InitializeComponent();
            DataContext = new ChangeLogViewModel();
        }
    }
}
