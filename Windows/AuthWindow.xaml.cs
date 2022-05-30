using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CoontrolBuisnesTile.EF;
using static CoontrolBuisnesTile.ClassSave;

namespace CoontrolBuisnesTile.Windows
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            var user = context.Employee.Where(q => q.Login == tbLogin.Text.Trim() && q.Password == tbPassword.Text.Trim()).FirstOrDefault();

            if(user != null)
            {
                ClassSave.employee = user;

                employee = user; 
                MainWindow main = new MainWindow();
                this.Hide();
                main.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Такого не пользователя не существует");
            }
        }
    }
}
