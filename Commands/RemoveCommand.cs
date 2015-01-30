using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProblemTracker.Commands
{
    public class RemoveCommand : ICommand 
    {
        dynamic _viewModel = null;

        public RemoveCommand(dynamic model)
        {
            _viewModel = model;
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanRemove;
        }

        public void Execute(object parameter)
        {
            _viewModel.Remove();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
