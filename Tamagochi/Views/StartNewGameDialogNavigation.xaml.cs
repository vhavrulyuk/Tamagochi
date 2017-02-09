using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tamagochi.ViewModels;
using TamagochiLogic;

namespace Tamagochi

{
    /// <summary>
    /// Логика взаимодействия для StartNewGameDialogNavigation.xaml
    /// </summary>
    public partial class StartNewGameDialogNavigation : Window
    {
       public StartNewGameDialogNavigation(MainViewModel context)
        {
            InitializeComponent();
            
            DataContext = context;
            
            //ColorAnimation colorAnimation = new ColorAnimation();
            //colorAnimation.To = Colors.BlueViolet;
            //colorAnimation.Duration = TimeSpan.Parse ("0:0:15");
            //textBlockInvitation.BeginAnimation(ForegroundProperty, colorAnimation);
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            Page p = PageContainer.Content as Page;
            if (p != null)
                p.DataContext = DataContext;
            else
                MessageBox.Show("Error!");
        }
    }
}
