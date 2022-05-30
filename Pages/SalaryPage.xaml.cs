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

namespace CoontrolBuisnesTile.Pages
{
    /// <summary>
    /// Interaction logic for SalaryPage.xaml
    /// </summary>
    public partial class SalaryPage : Page
    {
        public SalaryPage()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            var listToCalc = ClassSave.context.WorkTraffic.Where(tr => tr.IDEmployee == ClassSave.employee.IDEmployee && tr.StrartTime.Month == DateTime.Now.Month).ToList();
            
            decimal summ = 0;
            foreach (var item in listToCalc)
            {
                summ += Convert.ToDecimal((item.Employee.Busyness.HoursForWeek / 7)) * ClassSave.employee.Specialization.CostPerHOur;
            }

            tbSalary.Text = summ.ToString();
        }
    }
}
