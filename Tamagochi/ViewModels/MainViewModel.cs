using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.TeamFoundation.Common;
using Tamagochi.Models;
using TamagochiLogic;

namespace Tamagochi.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private CreateNewTamagochiCommand _createNewTamagochiCommand;
        private string _newTamagochiName;
        private TamagochiType _newTamagochiType;

        public ITamagochi CurrentTamagochi => GameManager.Instance.Tamagochi;

        public string TamagochiName
        {
            get { return _newTamagochiName; }
            set
            {
                _newTamagochiName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TamagochiName"));
            }
        }
        public TamagochiType NewTamagochiType
        {
            get { return _newTamagochiType; }
            set
            {
                _newTamagochiType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewTamagochiType"));
            }
        }


        public string ActualTamagochiName
        {
            get { return GameManager.Instance.Tamagochi?.Name; }
            set
            {
                GameManager.Instance.Tamagochi.Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiName"));
            }
        }



        public int? ActualTamagochiHealth
        {
            get { return GameManager.Instance.Tamagochi?.Health; }
            set
            {
                GameManager.Instance.Tamagochi.Health = value.GetValueOrDefault();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));
            }
        }
        

        //public TamagochiState ActualTamagochiState
        //{
        //    get { return GameManager.Instance.Tamagochi.Save(); }
        //    set { GameManager.Instance.Tamagochi.Load(value); }
        //}

        public ICommand CreateNewTamagochiCommand
        {
            get { return _createNewTamagochiCommand; }
        }
        
        

        public event PropertyChangedEventHandler PropertyChanged;

        internal void createNewTamagochi(object sender)

        {
            
            GameManager.Instance.CreateTamagochi(NewTamagochiType, TamagochiName);

            //Update value in View.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));
            MessageBox.Show("New tamagochi created!");
            //GameManager.Instance.Tamagochi.Health = 85;
           // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));

        }

        public bool BooleanProperty { get; set; }
        

        public void LoadGame(object sender)
        {
            InMemoryGameStateManager memoryGameStateManager = new InMemoryGameStateManager();
            memoryGameStateManager.LoadStateFromHdd();
            GameManager.Instance.RestoreTamagochi(memoryGameStateManager.Memento);
            //GameManager.Instance.Tamagochi.Load(memoryGameStateManager.Memento.TamagochiState);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));
        }

        public MainViewModel()
        {
            _createNewTamagochiCommand = new CreateNewTamagochiCommand(this);
            TamagochiName = "test";
            NewTamagochiType = TamagochiType.Dog;
        }
        public class RadioButtonCheckedConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
            {
                return value.Equals(parameter);
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
            {
                return value.Equals(true) ? parameter : Binding.DoNothing;
            }
        }
    }
    
}
