using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProblemTracker.Commands
{
    public class AddCommand : ICommand
    {

        dynamic _viewModel = null;

        public AddCommand(dynamic model)
        {
            _viewModel = model;    
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanAdd;
        }


        public void Execute(object parameter)
        {
            _viewModel.Add();
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
