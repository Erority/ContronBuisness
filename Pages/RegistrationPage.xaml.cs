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
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            cmbBusy.ItemsSource = ClassSave.context.Busyness.ToList();
            cmbBusy.DisplayMemberPath = "BusyName";
            cmbGender.ItemsSource = ClassSave.context.Gender.ToList();
            cmbGender.DisplayMemberPath = "GenderName";
            cmbSpec.ItemsSource = ClassSave.context.Specialization.ToList();
            cmbSpec.DisplayMemberPath = "NameSpec";
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (!valiation())
                return;

            Employee employee = new Employee();
            employee.Login = txtLogin.Text.Trim();
            employee.Password = txtPassword.Text.Trim();
            employee.FName = txtBoxFName.Text.Trim();
            employee.LName = txtBoxLName.Text.Trim();
            employee.MName = txtBoxMName.Text.Trim();

            employee.IDGender = ((Gender)cmbGender.SelectedItem).IDGender;
            employee.IDBusy= ((Busyness)cmbBusy.SelectedItem).IDBusy;
            employee.IDSpec = ((Specialization)cmbSpec.SelectedItem).IDSpec;

            employee.PassSeries = txtBoxPassportSerial.Text.Trim();
            employee.PassNumber = txtBoxPassportNumber.Text.Trim();

            try
            {
                ClassSave.context.Employee.Add(employee);
                ClassSave.context.SaveChanges();
                MessageBox.Show("Пользователь добавлен");
            } catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private bool valiation()
        {
            if(txtBoxFName.Text.Trim() == "")
            {
                MessageBox.Show("Введите имя");
                return false;
            }
            else if(txtBoxLName.Text.Trim() == "")
            {
                MessageBox.Show("Введите фамилию");
                return false;
            }
            else if (txtBoxMName.Text.Trim() == "")
            {
                MessageBox.Show("Введите отчество");
                return false;
            }
            else if (txtBoxPassportSerial.Text.Trim() == "")
            {
                MessageBox.Show("Введите серию паспорта");
                return false;
            }
            else if (txtBoxPassportSerial.Text.Trim().Length != 4)
            {
                MessageBox.Show("Серия паспорта должна быть 4 символа");
                return false;
            }
            else if (txtBoxPassportNumber.Text.Trim() == "")
            {
                MessageBox.Show("Введите номер паспорта");
                return false;
            }
            else if (txtBoxPassportNumber.Text.Trim().Length != 6)
            {
                MessageBox.Show("Номер паспорта должна быть 6 символа");
                return false;
            }
            else if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Введите логин");
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Введите пароль");
                return false;
            }
            else if(cmbBusy.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите занятость");
                return false;
            }
            else if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите гендер");
                return false;
            }
            else if (cmbSpec.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите специальность");
                return false;
            }

            return true;
        }
    }
}
