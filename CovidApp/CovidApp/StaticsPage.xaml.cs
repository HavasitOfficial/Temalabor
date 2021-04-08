using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public sealed partial class StaticsPage : Page
    {
        public StaticsPage()
        {
            this.InitializeComponent();
            Loading load = new Loading(@"PatientFiles\Patients.txt");
            load.loadingPatient();
            AverageAge avAge = new AverageAge(load.getPatients());

            staticsFirst.Height = avAge.getFirstColumn() * 10;
            staticSecond.Height = avAge.getSecondColumn() * 10;
            staticsThird.Height = avAge.getThirdColumn() * 10;
            staticsFourth.Height = avAge.getFourthColumn() * 10;
        }
    }
}
