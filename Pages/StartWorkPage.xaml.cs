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
using CoontrolBuisnesTile.EF;

namespace CoontrolBuisnesTile.Pages
{
    /// <summary>
    /// Interaction logic for StartWorkPage.xaml
    /// </summary>
    public partial class StartWorkPage : Page
    {

        DispatcherTimer _timer;
        TimeSpan _time;
        public StartWorkPage()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromHours(ClassSave.employee.Busyness.HoursForWeek/7);

            ClassSave.firstButton.IsEnabled = false;
            ClassSave.secondButton.IsEnabled = false;
            this.btnStart.IsEnabled = false;

            WorkTraffic workTraffic = new WorkTraffic();
            workTraffic.StrartTime = DateTime.Now;
            workTraffic.IDEmployee = ClassSave.employee.IDEmployee;

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbStart.Text = "До рабочего дня осталось:  " +  _time.ToString("c");
                if (_time == TimeSpan.Zero)
                {
                    ClassSave.firstButton.IsEnabled = true;
                    ClassSave.secondButton.IsEnabled = true;
                    this.btnStart.IsEnabled = true;

                    MessageBox.Show("Рабочий день окончен");

                    workTraffic.EndTime = DateTime.Now;

                    ClassSave.context.WorkTraffic.Add(workTraffic);

                    _timer.Stop();
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));

            }, Application.Current.Dispatcher);

            _timer.Start();
        }
    }
}
