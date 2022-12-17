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

namespace Authorisation.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            string Login = "Login";
            string Password = "Password";
            if (TxtBxLogin.Text == Login && TxtBxPassword.Text == Password)
            {
                NavigationService.Navigate(new SecondPage());
            }
            else
            {
                MessageBox.Show("Incorret data!");
            }
            
        }
    }
}
