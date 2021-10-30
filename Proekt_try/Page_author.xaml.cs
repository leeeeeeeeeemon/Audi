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

namespace Proekt_try
{
    /// <summary>
    /// Логика взаимодействия для Page_author.xaml
    /// </summary>
    public partial class Page_author : Page
    {
        public Page_author()
        {
            InitializeComponent();
        }

        //private void autho_event_clic(object sender, RoutedEventArgs e)
        //{
        //    userss  = new ObservableCollection<users>(bd_connection.connection.users.ToList());
        //    var z = userss.Where(a => a.login == txt_login.Text && a.password == txt_password).FirstOrDefault();
        //    if (z != null)
        //    {
        //        MessageBox.Show(z.name);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Логин или пароль неверный");
        //    }
        //}
    }
}
