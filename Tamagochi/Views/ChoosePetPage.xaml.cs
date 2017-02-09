using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tamagochi.ViewModels;
using TamagochiLogic;


namespace Tamagochi
{
    /// <summary>
    /// Логика взаимодействия для ChoosePetPage.xaml
    /// </summary>
    public partial class ChoosePetPage : Page
    {
        public ChoosePetPage()
        {
            
            //DataContext = context;
            //context.NewTamagochiType = TamagochiType.Cat;
            InitializeComponent();
            

            DoubleAnimation animateHeight = new DoubleAnimation();
            animateHeight.From = 15;
            animateHeight.To = 110;
            animateHeight.Duration = TimeSpan.Parse("0:0:3");

            DoubleAnimation animateWidth = new DoubleAnimation();
            animateWidth.From = 15;
            animateWidth.To = 150;
            animateWidth.Duration = TimeSpan.Parse("0:0:3");

            Storyboard sbKitty = new Storyboard();

            sbKitty.Duration = TimeSpan.Parse("0:0:4");


            sbKitty.Children.Add(animateHeight);
            sbKitty.Children.Add(animateWidth);

            Connector(animateHeight, "kittyPicture");
            Connector(animateWidth, "kittyPicture");


            sbKitty.Begin(kittyPicture);

            Storyboard sbPuppy = new Storyboard();

            sbPuppy.Duration = TimeSpan.Parse("0:0:4");

            sbPuppy.Children.Add(animateHeight);
            sbPuppy.Children.Add(animateWidth);

            Connector(animateHeight, "puppyPicture");
            Connector(animateWidth, "puppyPicture");

            sbPuppy.Begin(puppyPicture);



        }

        private void Connector(DoubleAnimation animateObject, String animatedObject)
        {
            Storyboard.SetTargetName(animateObject, animatedObject);
            Storyboard.SetTargetProperty(animateObject, new PropertyPath(Image.HeightProperty));
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {

            SoundPlayer soundPlayer = new SoundPlayer
            {
                SoundLocation = "Audio/nextPage.wav"
            };
            soundPlayer.Play();
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("/Views/SetPetNamePage.xaml", UriKind.RelativeOrAbsolute));
            
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = new SolidColorBrush(Colors.IndianRed);
        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = new SolidColorBrush(Colors.LightSalmon);
        }
    }
}
