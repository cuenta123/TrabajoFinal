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
using WpfApplication1;

namespace WpfApplication1
{
   
    public partial class register : Window, IRegister
    {
        public register()
        {
            InitializeComponent();
        }

        public void InsertUser(object sender, EventArgs e)
        {
            ViewMethodsRegister.InsertUser(sender,e,this);
        }

        public void PasswordIntro(object sender, KeyEventArgs e)
        {
            ViewMethodsRegister.PasswordIntro(sender,e,this);
        }

        public void UserIntro(object sender, KeyEventArgs e)
        {
            ViewMethodsRegister.UserIntro(sender, e, this);
        }

        public void ViewLogin(object sender, RoutedEventArgs e)
        {
            ViewMethodsRegister.ShowLogin();
        }

      
    }
}
