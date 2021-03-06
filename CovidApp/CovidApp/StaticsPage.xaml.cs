using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class StaticsPage : Page
    {
        List<Patient> patients = new List<Patient>();
        public StaticsPage()
        {
            Background=new SolidColorBrush(Colors.Gray);

            this.InitializeComponent();
            SaveAndLoadIn sali = new SaveAndLoadIn();
            patients = sali.getPatients();
            AverageAge avAge = new AverageAge(patients);
            FirstConverter.Text = (avAge.getFirstColumn() * 10).ToString();
            SecondConverter.Text = (avAge.getSecondColumn() * 10).ToString();
            ThirdConverter.Text = (avAge.getThirdColumn() * 10).ToString();
            FourthConverter.Text = (avAge.getFourthColumn() * 10).ToString();
            staticsFirst.Height = Int32.Parse(FirstConverter.Text);
            staticSecond.Height = Int32.Parse(SecondConverter.Text);
            staticsThird.Height = Int32.Parse(ThirdConverter.Text);
            staticsFourth.Height = Int32.Parse(FourthConverter.Text);

        }

        private void BackToHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

 
    }
}
