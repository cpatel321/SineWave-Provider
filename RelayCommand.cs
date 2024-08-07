using System;
using System.Windows.Input;

namespace SineGenerator
{
    public class RelayCommand : ICommand
    {
        private readonly Action execute;
        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.execute();
        }
    }
}
