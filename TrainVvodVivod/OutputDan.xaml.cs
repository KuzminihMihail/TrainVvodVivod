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

namespace TrainVvodVivod
{
    /// <summary>
    /// Логика взаимодействия для OutputDan.xaml
    /// </summary>
    public partial class OutputDan : Page
    {
        public OutputDan()
        {
            InitializeComponent();

            InfoGrd.ItemsSource = TrainDemEntities2.GetContext().Лист1_.ToList();
        }

        private void GoToAddBtnClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddPage(null));
        }

        private void DeleteBtnClick(object sender, RoutedEventArgs e)
        {
            if (InfoGrd.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выберите строку для удаления");
            }
            else
            {
                TrainDemEntities2.GetContext().Лист1_.Remove((Лист1_)InfoGrd.SelectedItem);
                TrainDemEntities2.GetContext().SaveChanges();
                MessageBox.Show("Запись удалена");
                InfoGrd.ItemsSource = TrainDemEntities2.GetContext().Лист1_.ToList();
            }
        }
    }
}
