using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для WinRegistrate.xaml
    /// </summary>
    public partial class WinRegistrate : Window
    {
        public WinRegistrate()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string login_r = log_r.Text;
            string password_r = pass_r.Text; 
            using (ZooWorldEntities db = new ZooWorldEntities())
            {
               Clients c = new Clients();
                c.login =   log_r.Text;
                c.password = pass_r.Text;
                c.role_id = 3;
                db.Clients.Add(c);
                db.SaveChanges();
                MessageBox.Show("Вы зарегистрированы");

            }
        }

        private void Vyhod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Hide();
        }
    }
}
