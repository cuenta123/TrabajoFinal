using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizzeria
{
    public partial class register : Form, IRegister
    {
        public register()
        {
            InitializeComponent();
        }

        public void ViewLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewMethodsRegister;


                }

        public void UserIntro(object sender, KeyPressEventArgs e)
        {
           
        }

        public void PasswordIntro(object sender, KeyPressEventArgs e)
        {
          
        }

        public void InsertUser (object sender, EventArgs e)
        {
            
        }
    }
}
