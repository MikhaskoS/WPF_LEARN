using System;
using System.Windows.Input;


namespace MVVM
{
    abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
    }

    class RelayCommand : Command
    {
        private readonly Action<object> _execute;        
        private readonly Func<object, bool> _canExecute;

        // выполняемое действие execute и возможность его выполнения canExecute
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute is null)
                throw new ArgumentNullException(nameof(execute));
            _execute = execute;
            _canExecute = canExecute;
        }


        // true - элемент включается, false - выключается
        public override bool CanExecute(object parameter)
        {
            //return _canExecute == null || _canExecute(parameter);
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public override void Execute(object parameter) => _execute(parameter);
    }
}
