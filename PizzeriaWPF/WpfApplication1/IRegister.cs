using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pizzeria
{
    interface IRegister
    {
        void ViewLogin(object sender, RoutedEventArgs e);
        void UserIntro(object sender, KeyEventArgs e);
        void PasswordIntro(object sender, KeyEventArgs e);
        void InsertUser(object sender, EventArgs e);
    }
}
