using System;






namespace kooliProject
{
    public class RelayCommand<T> : ICommand
    {
        readonly Action<T> _execute = null;
        readonly Predicate<T> _canExecute = null;

        public RelatyCommand(Action<T> execute) : this(execute, null)
        {
        }
        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null)
            
                throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            return _canExecute((T)parameter);
        }
    }

}