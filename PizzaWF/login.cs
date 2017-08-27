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
using Pizzeria.Models;

namespace Pizzeria
{
    public partial class login : Form, Ilogin
    {
       public String userLogeado;

        public login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ViewMethodLogin.Login(this);
        }

        public void LinkNewRegistre(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewMethodLogin.ShowFormRegister();
        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ViewMethodLogin.PulseEnter(this,e,sender);
        }

        public void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ViewMethodLogin.PulseEnter(this, e, sender);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
