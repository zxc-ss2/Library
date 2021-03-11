using StringCheckLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AutorizationPage());
        }

        private void StartBtnClick(object sender, RoutedEventArgs e)
        {
            StringCheck qwe = new StringCheck();

            bool isCorrectEmail = qwe.CheckEmail(EmailInput.Text);
            bool isCorrectFName = qwe.CheckFName(FirstNameInput.Text);
            bool isCorrectLName = qwe.CheckLName(LastNameInput.Text);
            bool isCorrectPassword = qwe.CheckPassword(PasswordInput.Password);

            if(isCorrectFName & isCorrectLName & isCorrectEmail & isCorrectPassword)
            {
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("+");
            }
        }
    }
}
