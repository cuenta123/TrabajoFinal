using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    interface IRegister
    {
        void ViewLogin(object sender, LinkLabelLinkClickedEventArgs e);
        void UserIntro(object sender, KeyPressEventArgs e);
        void PasswordIntro(object sender, KeyPressEventArgs e);
        void InsertUser(object sender, EventArgs e);
    }
}
