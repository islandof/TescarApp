using System;
using System.Windows.Input;

namespace VehicleManageApp.Mvvm
{
    public class SimpleCommand : ICommand
    {
        private readonly Func<bool> _canExecute;
        private readonly Action _execute;

        public SimpleCommand(Action execute)
            : this(execute, null)
        { }

        public SimpleCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? (() => { });
            _canExecute = canExecute ?? (() => true);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            var cec = CanExecuteChanged;
            if (null != cec)
            {
                cec(this, EventArgs.Empty);
            }
        }
    }

    public class SimpleCommand<T> : ICommand
    {
        private readonly Func<T, bool> _canExecute;
        private readonly Action<T> _execute;

        public SimpleCommand(Action<T> execute)
            : this(execute, null)
        { }

        public SimpleCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            _execute = execute ?? (p => { });
            _canExecute = canExecute ?? (p => true);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            var cec = CanExecuteChanged;
            if (null != cec)
            {
                cec(this, EventArgs.Empty);
            }
        }
    }
}
