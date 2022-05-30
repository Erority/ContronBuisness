using CoontrolBuisnesTile.Pages;
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


namespace CoontrolBuisnesTile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassSave.firstButton = this.btnStart;
            ClassSave.secondButton = this.btnCheck;

            if (ClassSave.employee.IDSpec == 5)
            {
                btnStart.Content = "Регистрация пользователя";
                btnCheck.Content = "Посещяаемость";
            }
            else
            {
                btnStart.Content = "Начать работу";
                btnCheck.Content = "Зарплата";
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (ClassSave.employee.IDSpec == 5)
            {
                MainFrame.Content = new RegistrationPage();
            }
            else
            {
                MainFrame.Content = new StartWorkPage();
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (ClassSave.employee.IDSpec == 5)
            {
                MainFrame.Content = new UsersTrafficPage();
            }
            else
            {
                MainFrame.Content = new SalaryPage();
            }
        }
    }
}
