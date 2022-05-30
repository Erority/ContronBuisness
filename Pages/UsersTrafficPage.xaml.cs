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
using CoontrolBuisnesTile.EF;

namespace CoontrolBuisnesTile.Pages
{
    /// <summary>
    /// Interaction logic for UsersTrafficPage.xaml
    /// </summary>
    public partial class UsersTrafficPage : Page
    {
        List<WorkTraffic> workTraffics;
        List<WorkTraffic> fullTrafic;
        public UsersTrafficPage()
        {
            InitializeComponent();

            List<WorkTraffic> buff = ClassSave.context.WorkTraffic.ToList();
            dg.ItemsSource = buff;
            workTraffics = buff;
            fullTrafic = buff;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            workTraffics = fullTrafic.Where(ft => ft.Employee.FIO.Contains(tbLogin.Text) || ft.StrartTime.ToString().Contains(tbLogin.Text)).ToList();

            if(workTraffics.Count == 0)
            {
                MessageBox.Show("Поиск не дал резултатов");
                dg.ItemsSource = fullTrafic;
                tbLogin.Text = "";  
            } 
            else
            {
                dg.ItemsSource = workTraffics;
            }
        }
    }
}
