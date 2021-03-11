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

namespace Library.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        Core.libraryEntities context = new Core.libraryEntities();

        public AutorizationPage()
        {
            InitializeComponent();
        }

        public bool Auth(string login, string password)
        {
            var userLogin = context.client.AsNoTracking().FirstOrDefault(u => u.login == login);

            if(userLogin == null)
            {
                MessageBox.Show("-");
                return false;
            }

            var user = context.client.AsNoTracking().FirstOrDefault(u => u.login == login && u.password == password);

            if (user == null)
            {
                MessageBox.Show("-");
                return false;
            }

            return true;
        }

        private void SignUpBtnClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage());
        }

        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {
            if (Auth(LoginTextBox.Text, PasswordTextBox.Text))
            {
                this.NavigationService.Navigate(new RegistrationPage());
            }
        }
    }
}
