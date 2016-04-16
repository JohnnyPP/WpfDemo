using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDemo.ViewModel.Helper
{
    class ActionCommand : ICommand
    {
        private Action _action;

        public ActionCommand(Action command)
        {
            _action = command;
        }

        #region ICommand implementation

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
