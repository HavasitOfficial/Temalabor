using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class ListInfected : Page, INotifyPropertyChanged
    {
        public List<Patient> originalPatients { get; set; }
        public List<Patient> patinets;


        List<string> DropdownItems = new List<string>();

        public List<Patient> Patinets
        {
            get { return patinets; }
            set
            {
                if (patinets != value)
                {
                    patinets = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ListInfected()
        {
            this.InitializeComponent();
            Loading load = new Loading(@"PatientFiles\Patients.txt");
            load.loadingPatient();
            originalPatients = load.getPatients();
            Patinets = originalPatients;
            DropdownItems.Add("Name");
            DropdownItems.Add("Regio");
            DropdownItems.Add("Sex");

        }

        private void BackToHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private List<Patient> basedOnName()
        {
            if (SearchString.Text == "")
            {
                return originalPatients;
            }
            var sv = new List<Patient>();
            string[] parts = SearchString.Text.Split(" ");
            foreach (var item in this.Patinets)
            {
                if (item.FamilyName == parts[0] && item.FirstName == parts[1])
                {
                    sv.Add(item);
                }
            }
            return sv;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Patinets = basedOnName();
            //new Windows.UI.Popups.MessageDialog(SearchString.Text).ShowAsync();

        }
    }
}
