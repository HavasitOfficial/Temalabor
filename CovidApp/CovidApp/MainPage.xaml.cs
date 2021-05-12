using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CovidApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }


        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var load = new Loading(@"UserPass\UserAndPass.txt");
            load.UsernameAndPasswordLoading();
            var signIn = new SignIn();
            signIn.CheckUserAndPass(Username.Text, Password.Password, load.getUsers(), load.getPasswords());
            if (signIn.RegisterAllow())
            {
                register.IsEnabled = true;
            }
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            popUp.IsOpen = true;
        }

        private void Statics_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StaticsPage));
        }

        private void infected_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ListInfected));
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddNewCovidPatient));
        }

        private void OpenClose_Click(object sender, RoutedEventArgs e)
        {
            MenuSplitView.StartBringIntoView();

            if (MenuSplitView.IsPaneOpen == false)
            {
                MenuSplitView.IsPaneOpen = true;
            }
            else
            {
                MenuSplitView.IsPaneOpen = false;
            }

        }
    }
}
