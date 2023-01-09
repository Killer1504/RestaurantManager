using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VfxLib.Commands
{

    public class VfxCommand : ICommand
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
        public VfxCommand(Action<object> __targetExcute)
        {
            _targerExcuteMethod = __targetExcute;
        }
        public VfxCommand(Action<object> __targetExecute, Func<bool> __targetCanExecute)
        {
            _targerExcuteMethod = __targetExecute;
            _targerCanExcuteMethod = __targetCanExecute; ;
        }
    }
}
