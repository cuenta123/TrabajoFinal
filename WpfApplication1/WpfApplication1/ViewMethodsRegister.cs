
using System;
using System.Windows.Input;
using Pizzeria;
using System.Data.SqlClient;
using System.Windows;
using LinqToSqlStringBuilder;

namespace WpfApplication1
{
    public static class ViewMethodsRegister
    {
        public static void ShowLogin()
        {
            Login objetologin = new Login();
            objetologin.Show();
        }

        public static void UserIntro(object sender, KeyEventArgs e, register form)
            {
                if (e.Key == Key.Enter)
                {
                    form.txtEmail.Focus();
                }
            }

            public static void PasswordIntro(object sender, KeyEventArgs e, register form)
            {
                if (e.Key == Key.Enter)
                {
                    form.txtPassword.Focus();
                }
            }

            public static void InsertUser(object sender, EventArgs e, register form)
            {
                SqlConnection connection = null;
                SqlCommand cmd = null;
                try
                {
                    connection = new SqlConnection(ListConexion.GetDataSource());
                    connection.Open();
                    cmd = new SqlCommand("Insert into usuario (Id,nombre,pass,correo) values (@id,@nombre,@pass,@correo)", connection);
                    cmd.Parameters.AddWithValue("@id", Guid.NewGuid());
                    cmd.Parameters.AddWithValue("@nombre", form.txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", form.txtPassword.Password);
                    cmd.Parameters.AddWithValue("@correo", form.txtEmail.Text);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                    MessageBox.Show("Se ha registrado con exito.");
                    MainWindow fm = new MainWindow();
                    fm.Show();
                    form.Hide();
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        
    }
}
