using System.Media;
using System.Windows;
using System.Windows.Input;
using Tamagochi.Models;
using Tamagochi.ViewModels;
using TamagochiLogic;

namespace Tamagochi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _vm;
        public MainWindow()
        {
            _vm = new MainViewModel();
            DataContext = _vm;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "Audio/startGame.wav";
            soundPlayer.Play();

            StartNewGameDialogNavigation start = new StartNewGameDialogNavigation(_vm);
            start.DataContext = _vm;
            start.ShowDialog();
        }

        private void SaveGame(object sender, RoutedEventArgs e)
        {
            InMemoryGameStateManager memoryGameStateManager = new InMemoryGameStateManager();
            memoryGameStateManager.Memento = new GameState(100);
            memoryGameStateManager.SaveStateOnHDD();
        }
        

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadGame(object sender, RoutedEventArgs e)
        {
            _vm.LoadGame(sender);
           
        }
    }
}
