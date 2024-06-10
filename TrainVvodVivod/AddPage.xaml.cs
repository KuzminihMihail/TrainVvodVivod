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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        private Лист1_ _newZapis = new Лист1_();

        

        public AddPage(Лист1_ selectedZapis)
        {
            InitializeComponent();
            if (selectedZapis != null)
                _newZapis = selectedZapis;

            DataContext = _newZapis;
        }

        private void AddZapBtnClick(object sender, RoutedEventArgs e)
        {
            TrainDemEntities2.GetContext().Лист1_.Add(_newZapis);
            TrainDemEntities2.GetContext().SaveChanges();
            Manager.MainFrame.Navigate(new OutputDan());
            MessageBox.Show("Запись добавлена");
        }

        private void BackPageBtnClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack(); 
        }
    }
}
