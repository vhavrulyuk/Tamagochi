using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tamagochi.ViewModels
{
    internal class CreateNewTamagochiCommand : ICommand
    {
        private MainViewModel _mvm;
        private bool _canExecute = false;

        private bool IntenalCanExecute
        {
            get { return _canExecute; }
            set
            {
                if (_canExecute != value)
                {
                    _canExecute = value;
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler CanExecuteChanged;

        public CreateNewTamagochiCommand(MainViewModel mvm)
        {
            _mvm = mvm;
            mvm.PropertyChanged += MvmOnPropertyChanged;
        }

        private void MvmOnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName.Equals("TamagochiName"))
            {
                IntenalCanExecute = !string.IsNullOrEmpty(_mvm.TamagochiName);
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _mvm.createNewTamagochi(this);
        }
    }
}
