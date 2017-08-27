using Pizzeria;
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

namespace WpfApplication1
{

    public partial class Login : Window, Ilogin
    {
        public Login()
        {
            InitializeComponent();
        }

        public void CheckUserPassword(object sender, EventArgs e)
        {
            ViewMethodLogin.Login(this);
        }

        public void LinkNewRegistre(object sender, RoutedEventArgs e)
        {
            ViewMethodLogin.ShowFormRegister();
        }

        public void PressEntertxtPassword(object sender, KeyEventArgs e)
        {
            ViewMethodLogin.PulseEnter(this,e,sender);
        }

        public void PressEntertxtUser(object sender, KeyEventArgs e)
        {
            ViewMethodLogin.PulseEnter(this, e, sender);
        }
    }
}
