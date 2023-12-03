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
using TaskManager.Models;

namespace TaskManager.PagesProget
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
            DGridTask.ItemsSource = App.DB.Tasks.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var TasksBD = DGridTask.SelectedItems as Tasks;
            if (TasksBD != null)
            {
                App.DB.Tasks.Remove(TasksBD);
                App.DB.SaveChanges();
                DGridTask.ItemsSource = App.DB.Tasks.ToList();
            }
            else
            {
                MessageBox.Show("Вы нечего не выбрали");
            }
        }
    }
}
