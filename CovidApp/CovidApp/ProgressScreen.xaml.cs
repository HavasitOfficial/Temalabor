using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class ProgressScreen : Page
    {
        public ProgressScreen()
        {
            this.InitializeComponent();
            startProgressBar();

            DispatcherTimer t = new DispatcherTimer();
            t.Interval = TimeSpan.FromSeconds(6.5);
            t.Tick += (s, e) =>
            {
                this.Frame.Navigate(typeof(MainPage));
                t.Stop();
            };
            t.Start();

        }
        async void startProgressBar()
        {
            var progressReporter = new Progress<double>(percent => this.progressB.Value = percent);

            await Task.Run(async () => await DoItAsync(progressReporter));
        }


        async Task DoItAsync(IProgress<double> progress)
        {
            for (double i = 0; i <= 100; i += 0.5)
            {
                Task.Delay(18).Wait();
                progress.Report(i);
            }
        }
    }
}
