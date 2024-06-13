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
using System.Windows.Shapes;

namespace ZooWorld_Larin
{
    /// <summary>
    /// Логика взаимодействия для WinProd.xaml
    /// </summary>
    public partial class WinProd : Window
    {
        public WinProd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Hide();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource clientsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientsViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // clientsViewSource.Source = [универсальный источник данных]
            System.Windows.Data.CollectionViewSource clientsViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientsViewSource1")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // clientsViewSource1.Source = [универсальный источник данных]
            System.Windows.Data.CollectionViewSource clientsViewSource2 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientsViewSource2")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // clientsViewSource2.Source = [универсальный источник данных]
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
