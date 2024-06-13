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

namespace ZooWorld_Larin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        internal static int id_user = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log_u = Log.Text;
            string pass_u = Pass.Text;

            Clients client_id = null;
            int id;            
            using (ZooWorldEntities db = new ZooWorldEntities())
            {
                client_id =  db.Clients.Where(b => b.login == log_u && b.password == pass_u).FirstOrDefault();

                if (client_id != null)
                {
                    id = Convert.ToInt32(client_id.role_id);
                    switch (id)
                    {
                        case 1:

                            WinAdmin WA = new WinAdmin();
                            WA.Show();
                            Hide();
                            MessageBox.Show("Вы вошли в аккаунт Админа");

                            break;

                        case 2:

                            WinManager WM = new WinManager();
                            WM.Show();
                            Hide();
                            MessageBox.Show("Вы вошли в аккаунт Менеджера");

                            break;

                        case 3:

                            WinClient WC = new WinClient();
                            WC.Show();
                            Hide();
                            MessageBox.Show("Вы вошли в аккаунт Клиента");

                            break;
                    }
                }
                else
                    MessageBox.Show("Неправильный Логин или Пароль");
                }
            }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WinProd WP = new WinProd();
            WP.Show();
            Hide();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            WinRegistrate WR = new WinRegistrate();
            WR.Show();
            Hide();
        }
    }
    }
