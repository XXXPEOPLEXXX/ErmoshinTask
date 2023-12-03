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

namespace TaskManager.PagesProget
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
            
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.UsersTable.FirstOrDefault(x => x.Login == LoginAuth.Text && x.Password == PasswordAuth.Text);

            if(user == null)
            {
                MessageBox.Show("Введены неверные данные");
                return; 
            }
            NavigationService.Navigate(new TaskPage());
        }
    }
}
