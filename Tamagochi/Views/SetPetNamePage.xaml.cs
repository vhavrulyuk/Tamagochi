using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tamagochi.ViewModels;
using TamagochiLogic;

namespace Tamagochi
{
    /// <summary>
    /// Логика взаимодействия для setPetName.xaml
    /// </summary>
    public partial class setPetName : Page
    {
        public setPetName()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "Audio/nextPage.wav";
            soundPlayer.Play();
        }

        private void petName_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window thisWindow = Window.GetWindow(this);
            thisWindow?.Close();
        }
    }
}
