using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.TeamFoundation.Common;
using TamagochiLogic;

namespace Tamagochi.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string _tamagochiName;
        private CreateNewTamagochiCommand _createNewTamagochiCommand;

        public ITamagochi CurrentTamagochi
        {
            get { return GameManager.Instance.Tamagochi; }
        }
        public string TamagochiName
        {
            get { return _tamagochiName; }
            set
            {
                _tamagochiName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TamagochiName"));
            }
        }

        public ICommand CreateNewTamagochiCommand
        {
            get { return _createNewTamagochiCommand; }
        }
        private TamagochiType Type { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void createNewTamagochi(object sender)
        {
            GameManager.Instance.CreateTamagochi(Type, TamagochiName);            
            MessageBox.Show("New tamagochi created!");
        }

        public MainViewModel()
        {
            _createNewTamagochiCommand = new CreateNewTamagochiCommand(this);
            TamagochiName = "test";
          
        }

    }
}
