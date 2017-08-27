using LinqToSql;
using Pizzeria.Models;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApplication1;

namespace Pizzeria
{
    public static class ViewMethodsVerPizza
    {
        public static void LoadValues(PizzaDetail form, Pizza Pizza)
        {
            //TODO Reformar metodo para que no llame 3 veces a a getlastpizzacomment.getcomment
            form.nombrePizza.Content = Pizza.Nombre;
            try
            {
                BitmapImage bp = new BitmapImage();
                bp.UriSource = new Uri(Pizza.Foto);
                form.image.Source = bp;
            }
            catch (Exception)
            {
                MessageBox.Show("Imagen no encontrada");
            }
            form.precioPizza.Content = Pizza.Precio.ToString();
            form.ingredientsText.ItemsSource = Pizza.Ingredientes;

            form.lastComment.Text = GetLastPizzaComent.GetComment(Pizza.Id).Texto;
            form.fechaText.Text = GetLastPizzaComent.GetComment(Pizza.Id).Fecha.ToString();
            form.nombreUser.Text = GetLastPizzaComent.GetComment(Pizza.Id).Usuario.ToString();
        }

        public static void SubmitComment(PizzaDetail form, Pizza Pizza)
        {
            int estrellas = form.puntuacion.SelectedIndex;
            if (estrellas == -1)
            {
                MessageBox.Show("Elige la puntuacion de la pizza");
            }
            else
            {
                Comentario c = new Comentario() { Id = Guid.NewGuid(), Fecha = DateTime.Now, Pizza = Pizza.Id, Usuario = GetCurrentUser.Id, Puntuacion = estrellas, Texto = form.comentarioText.Text };
                GenericDaoEntityFramework gdao = new GenericDaoEntityFramework();
                gdao.InsertSQL(Generic.ToGeneric(c));
                form.lastComment.Text = c.Texto;
            }
        }

    }
}
