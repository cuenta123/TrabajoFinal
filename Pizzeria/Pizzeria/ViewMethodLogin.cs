using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    class ViewMethodLogin
    {
        public static void Login(login form)
        {
            if (form.textBox1.Text == "")
            {
                MessageBox.Show("Rellene el campo usuario");
                return;
            }
            if (form.textBox2.Text == "")
            {
                MessageBox.Show("Rellene los campo contraseña ");
                return;
            }
            CheckUserBD check = new CheckUserBD();
            var result = check.ComproveUserPasswordBD(form.textBox1.Text, form.textBox2.Text);

            if (result == 1)
            {
                GetCurrentUser.SelectIdbyNick(form.textBox1.Text);
                form.Hide();
                Main mainForm = new Main();
                mainForm.Show();
            }
        }

        public static void ShowFormRegister()
        {
            register ss = new register();
            ss.Show();
        }

        public static void PulseEnter(login form, KeyPressEventArgs e,object sender)
        {
            if (sender.Equals(form.textBox1) && e.KeyChar == (char)13)
            {
                form.textBox2.Focus();
            }
            if (sender.Equals(form.textBox2) && e.KeyChar == (char)13)
            {
                Login(form);
            }

        }
    }
}
