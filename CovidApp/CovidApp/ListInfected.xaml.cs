using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
        private List<Patient> originalPatients { get; set; }
        private List<Patient> patinets;

        private readonly List<string> DropdownItems = new List<string>() { "Name", "Regio","All"};
        private bool byName=false, byRegio=false, all = true;


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
            SaveAndLoadIn sali = new SaveAndLoadIn();
            originalPatients = sali.getPatients();
            Patinets = originalPatients;
            

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
            foreach (var item in this.originalPatients)
            {
                if (item.FamilyName == parts[0] && item.FirstName == parts[1])
                {
                    sv.Add(item);
                }
            }
            return sv;
        }

        private List<Patient> basedOnRegio()
        {
            var sv = new List<Patient>();

            foreach (var item in this.originalPatients)
            {
                if (item.Region == SearchString.Text)
                {
                    sv.Add(item);
                }
            }

            return sv;

        }

 

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
           
            if (this.byName)
            {
                Patinets = basedOnName();
            }
            else if (this.byRegio)
            {
                Patinets = basedOnRegio();
            }
            else if (this.all)
            {
                Patinets = originalPatients;
            }
            else
            {
                Patinets = null;
            }
            
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                ListViewItem lvi = (sender as ListView).ContainerFromItem(item) as ListViewItem;
                if (lvi.IsSelected)
                {
                    lvi.Background= new SolidColorBrush(Colors.LightBlue);
                    if (lvi.Content == "Name")
                    {
                        this.byName = true;
                        this.byRegio = false;
                        this.all = false;
                        SearchBasedOn.Content = item.ToString();
                        SearchString.Text = "";
                        SearchString.IsEnabled = true;
                    }
                    else if (lvi.Content == "Regio")
                    {
                        this.byName = false;
                        this.byRegio = true;
                        this.all = false;
                        SearchBasedOn.Content = item.ToString();
                        SearchString.Text = "";
                        SearchString.IsEnabled = true;
                    }
                    else if(lvi.Content == "All")
                    {
                        this.byName = false;
                        this.byRegio = false;
                        this.all = true;
                        SearchBasedOn.Content = item.ToString();
                        SearchString.Text = "";
                        SearchString.IsEnabled = false;
                    }
                    SearchString.PlaceholderText = item.ToString();
                }
            }
        }
    }
}
