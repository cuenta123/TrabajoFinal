using LinqToSql;
using Pizzeria.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizzeria
{
    public static class ViewMethodsVerPizza
    {
        public static void LoadValues(VerPizza form, Pizza Pizza)
        {
            form.nombrePizza.Text = Pizza.Nombre;
            try
            {
                form.fotoPizza.Image = Image.FromFile(Pizza.Foto);
            }
            catch (Exception)
            {
                MessageBox.Show("Imagen no encontrada");
            }
            form.precioPizza.Text = Pizza.Precio.ToString();
            form.ingredientsText.Text = Pizza.Ingredientes;

            form.lastComment.Text = GetLastPizzaComent.GetComment(Pizza.Id).Texto;
            form.fechaText.Text = GetLastPizzaComent.GetComment(Pizza.Id).Fecha.ToString();
            form.textoUsuarioComentario.Text = GetLastPizzaComent.GetComment(Pizza.Id).Usuario.ToString();
        }

        public static void SubmitComment(VerPizza form, Pizza Pizza)
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
