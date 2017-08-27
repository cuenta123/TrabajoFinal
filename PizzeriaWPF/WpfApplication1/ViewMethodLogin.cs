using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApplication1;

namespace Pizzeria
{
    class ViewMethodLogin
    {
      

        public static void Login(Login form)
        {
            if (form.txtUsername.Text == "")
            {
                MessageBox.Show("Rellene el campo usuario");
                return;
            }
            if (form.txtPassword.Password == "")
            {
                MessageBox.Show("Rellene los campo contraseña ");
                return;
            }
            CheckUserBD check = new CheckUserBD();
            var result = check.ComproveUserPasswordBD(form.txtUsername.Text, form.txtPassword.Password);

            if (result == 1)
            {
                GetCurrentUser.SelectIdbyNick(form.txtUsername.Text);
                form.Hide();
                MainWindow mainForm = new MainWindow();
                mainForm.Show();
            }
        }

        public static void ShowFormRegister()
        {
            register ss = new register();
            ss.Show();
        }

        public static void PulseEnter(Login form, KeyEventArgs e,object sender)
        {
            if (sender.Equals(form.txtUsername) && e.Key == Key.Enter )
            {
                form.txtPassword.Focus();
            }
            if (sender.Equals(form.txtPassword) && e.Key == Key.Enter)
            {
                Login(form);
            }

        }
    }
}
