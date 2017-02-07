using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private TamagochiType Type { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void createNewTamagochi(object sender)
        {
            GameManager.Instance.CreateTamagochi(Type, TamagochiName);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));
            MessageBox.Show("New tamagochi created!");
            //GameManager.Instance.Tamagochi.Health = 85;
           // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));

        }

        public void LoadGame(object sender)
        {
            InMemoryGameStateManager memoryGameStateManager = new InMemoryGameStateManager();
            memoryGameStateManager.LoadStateFromHdd();
            GameManager.Instance.Tamagochi.Load(memoryGameStateManager.Memento.TamagochiState);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActualTamagochiHealth"));
        }

        public MainViewModel()
        {
            _createNewTamagochiCommand = new CreateNewTamagochiCommand(this);

            TamagochiName = "test";
        }
    }
}
