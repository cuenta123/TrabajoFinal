using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pizzeria
{
    interface Ilogin
    {
        void CheckUserPassword(object sender, EventArgs e);
        void LinkNewRegistre(object sender, RoutedEventArgs  e);
        void PressEntertxtUser(object sender, KeyEventArgs e);
        void PressEntertxtPassword(object sender, KeyEventArgs e);
    }
}
