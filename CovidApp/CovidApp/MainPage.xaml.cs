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
            
            /*var key = "b14ca5898a4e4133bbce2ea2315a1916";

            //Console.WriteLine("Please enter a secret key for the symmetric algorithm.");  
            //var key = Console.ReadLine();  

            Console.WriteLine("Please enter a string for encryption");
            //var str = Console.ReadLine();
            
            var encryptedString = encrypt(key,"jelszo123");
            var encryptedString2 = encrypt(key,"jelszo456");
            var encryptedString3 = encrypt(key,"jelszo789");
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = DecryptString(key, encryptedString);

            new Windows.UI.Popups.MessageDialog($"encrypted string1 = {encryptedString}").ShowAsync();
            new Windows.UI.Popups.MessageDialog($"encrypted string2 = {encryptedString2}").ShowAsync();
            new Windows.UI.Popups.MessageDialog($"encrypted string3 = {encryptedString3}").ShowAsync();
            new Windows.UI.Popups.MessageDialog($"encrypted string3 = {decryptedString}").ShowAsync();
                */

        }

        /*private String encrypt(string key, string plainText )
        {
            
            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }*/

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var load = new Loading(@"UserPass\UserAndPass.txt");
            load.UsernameAndPasswordLoading();
            var signIn = new SignIn();
            signIn.CheckUserAndPass(Username.Text, Password.Text, load.getUsers(), load.getPasswords());
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
