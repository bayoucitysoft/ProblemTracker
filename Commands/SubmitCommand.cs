using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProblemTracker.Commands
{
    public class SubmitCommand : ICommand 
   {
        dynamic _viewModel = null;

        public SubmitCommand(dynamic model)
        {
            _viewModel = model;
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanSubmit;
        }

        public void Execute(object parameter)
        {
            _viewModel.Submit();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
