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

namespace TaskManager.PagesProget.AddPages
{
    /// <summary>
    /// Логика взаимодействия для AddTaskPage.xaml
    /// </summary>
    public partial class AddTaskPage : Page
    {
        public static Tasks Taskses = new Tasks(); // создание объекта который необходимо заполнить данными
        public AddTaskPage()
        {
            InitializeComponent();
        }

        private void BtnSaveTasks_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TBCompleted.Text))
            {

            }
            Taskses.Description = TBId.Text;          // заполнение Атрибута1 объекта
            Taskses.Importance = Convert.ToInt32(TBDescription.Text);  // строкой из TextBox
            //Taskses.DeadLine = TBImportance.Text;
            Taskses.Completed = TBDeadLine.AcceptsTab;   //Заполнение остальных атрибутов аналогичным способом
            //Taskses.IdUsersTable = System.Convert.ToInt32.TBIdUserBIdUser;
            App.DB.Tasks.Add(Taskses);
            App.DB.SaveChanges();
        }
    }
}
