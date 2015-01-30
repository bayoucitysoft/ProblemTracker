using ProblemTracker.Views;
using ProblemTracker.Views.LiquibaseViews;
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

namespace ProblemTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void NewEntry_Click(object sender, RoutedEventArgs e)
        {
            MainPanel.NavigationService.Navigate(new NewEntryView(MainPanel));
        }

        private void ModifyEntry_Click(object sender, RoutedEventArgs e)
        {
            MainPanel.NavigationService.Navigate(new ModifyEntryView(MainPanel));
        }

        private void RemoveEntry_Click(object sender, RoutedEventArgs e)
        {
            //MainPanel.NavigationService(new RemoveEntryView(MainPanel));
        }

        private void LiquibaseAdd_Click(object sender, RoutedEventArgs e)
        {
            MainPanel.NavigationService.Navigate(new LiquibaseAddView());
        }


    }
}
