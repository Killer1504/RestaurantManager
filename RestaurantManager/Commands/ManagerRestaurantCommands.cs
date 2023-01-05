using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RestaurantManager.Commands
{
    //class ManagerRestaurantTestCommands : ICommand
    //{
    //    private Action<object> _TargetExecuteMethod;
    //    private Func<bool> _TargetCanExecuteMethod;

    //    public ManagerRestaurantTestCommands(Action<object> executeMethod)
    //    {
    //        _TargetExecuteMethod = executeMethod;
    //    }

    //    public ManagerRestaurantTestCommands(Action<object> executeMethod, Func<bool> canExecuteMethod)
    //    {
    //        _TargetExecuteMethod = executeMethod;
    //        _TargetCanExecuteMethod = canExecuteMethod;
    //    }

    //    public void RaiseCanExecuteChanged()
    //    {
    //        if (this != null)
    //        {
    //            CanExecuteChanged(this, EventArgs.Empty);
    //        }
    //    }

    //    bool ICommand.CanExecute(object parameter)
    //    {
    //        return _TargetCanExecuteMethod != null ? _TargetCanExecuteMethod() : _TargetExecuteMethod != null;
    //    }

    //    // Beware - should use weak references if command instance lifetime
    //    //  is longer than lifetime of UI objects that get hooked up to command

    //    // Prism commands solve this in their implementation
    //    public event EventHandler CanExecuteChanged = delegate { };

    //    void ICommand.Execute(object parameter)
    //    {
    //        _TargetExecuteMethod(parameter);
    //    }

    //}

    public class ManagerRestaurantCommands : ICommand
    {
        private Action<object> _targerExcuteMethod;
        private Func<bool> _targerCanExcuteMethod;

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExcuteChanged()
        {
            if(this != null)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public bool CanExecute(object parameter)
        {
            return _targerCanExcuteMethod != null ? _targerCanExcuteMethod() : _targerExcuteMethod != null;
        }

        public void Execute(object parameter)
        {
            _targerExcuteMethod(parameter);
        }
        public ManagerRestaurantCommands(Action<object> __targetExcute)
        {
            _targerExcuteMethod = __targetExcute;
        }
        public ManagerRestaurantCommands(Action<object> __targetExecute, Func<bool> __targetCanExecute)
        {
            _targerExcuteMethod = __targetExecute;
            _targerCanExcuteMethod = __targetCanExecute; ;
        }
    }
}
