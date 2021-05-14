using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CovidApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNewCovidPatient : Page, INotifyPropertyChanged
    {
        public AddNewCovidPatient()
        {
            DataContext = this;
            this.InitializeComponent();
        }

        private int _ageNumber;
        public int AgeNumber
        {
            get { return _ageNumber; }
            set
            {
                if (_ageNumber != value)
                {
                    _ageNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string patientSexBox()
        {
            if ((bool)male.IsChecked)
            {
                return "male";
            }
            return "famale";
        }

        private void male_Checked(object sender, RoutedEventArgs e)
        {
            if (male.IsChecked == true)
            {
                famale.IsChecked = false;
            }
        }

        private void famale_Checked(object sender, RoutedEventArgs e)
        {
            if (famale.IsChecked == true)
            {
                male.IsChecked = false;
            }

        }
        private async void enableButtonAsync()
        {

            if (patientName.Text == "" || patientEmailAddress.Text == "" || patientAge.Text == "" || patientRegion.Text == "" || (male.IsChecked == false && famale.IsChecked == false))
            {
                var messageDialog = new MessageDialog("Please complete everything!");
                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 1;
                await messageDialog.ShowAsync();
            }
            return;
        }
        public List<string> SymptomesList()
        {
            List<string> symptomes = new List<string>();
            string symptome1 = "Nosmell";
            string symptome2 = "Fever ";
            string symptome3 = "Headache";
            string symptome4 = "Notaste";
            string wp = " ";
            if (noSmell.IsChecked == true)
            {
                symptomes.Add(symptome1);
            }
            if (noSmell.IsChecked == false)
            {
                symptomes.Add(wp);
            }
            if (noTaste.IsChecked == true)
            {
                symptomes.Add(symptome2);
            }
            if (noTaste.IsChecked == false)
            {
                symptomes.Add(wp);
            }
            if (fever.IsChecked == true)
            {
                symptomes.Add(symptome3);
            }
            if (fever.IsChecked == false)
            {
                symptomes.Add(wp);
            }
            if (headache.IsChecked == true)
            {
                symptomes.Add(symptome4);
            }
            if (headache.IsChecked == false)
            {
                symptomes.Add(wp);
            }
            return symptomes;
        }
        private async void addNewPatient(object sender, RoutedEventArgs e)
        {

            ValidateRegex reg = new ValidateRegex();
            var symptomes = SymptomesList();

            var name = patientName.Text;
            string[] fullName = name.Split(" ");
            Patient pat = new Patient(fullName[0], fullName[1], patientAge.Text, patientEmailAddress.Text, patientPhoneNumber.Text,patientSexBox(), patientRegion.Text, symptomes);
            SaveAndLoadIn sali = new SaveAndLoadIn();
            enableButtonAsync();
            reg.validateNameAndEmail(patientName.Text, patientEmailAddress.Text);
            sali.savePatient(pat);
            await nullAllBox();
        }

        private void backToHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async Task nullAllBox()
        {
            patientAge.Text = "";
            patientEmailAddress.Text = "";
            patientName.Text = "";
            patientPhoneNumber.Text = "";
            patientRegion.Text = "";
            AgeNumber = 0;
            male.IsChecked = false;
            famale.IsChecked = false;
            noSmell.IsChecked = false;
            noTaste.IsChecked = false;
            headache.IsChecked = false;
            fever.IsChecked = false;
        }
    }
}
