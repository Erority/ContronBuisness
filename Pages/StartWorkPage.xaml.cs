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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CoontrolBuisnesTile.Pages
{
    /// <summary>
    /// Interaction logic for StartWorkPage.xaml
    /// </summary>
    public partial class StartWorkPage : Page
    {

        DispatcherTimer _timer;
        int _time = 15;

        public StartWorkPage()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

            btnStart.Visibility = Visibility.Hidden;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if(_time > 0)
            {
                _time--;
                tbStart.Text = $"{_time}";
            } 
            else
            {
                _timer.Stop();
                MessageBox.Show("STOP");
            }
        }
    }
}
