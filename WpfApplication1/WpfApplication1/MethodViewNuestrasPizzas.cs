using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Pizzeria
{
    static class MethodViewNuestrasPizzas
    {
        public static void VerPizza(NuestrasPizzas form, object sender)
        {
            VerPizza pizzaDetailForm = null;

            if (sender.Equals(form.fotoPizza1))
            {
                pizzaDetailForm = new VerPizza(form.pizzaPage.ElementAt(0));
            }

            if (sender.Equals(form.fotoPizza2))
            {
                pizzaDetailForm = new VerPizza(form.pizzaPage.ElementAt(1));
            }

            if (sender.Equals(form.fotoPizza3))
            {
                pizzaDetailForm = new VerPizza(form.pizzaPage.ElementAt(2));
            }

            if (sender.Equals(form.fotoPizza4))
            {
                pizzaDetailForm = new VerPizza(form.pizzaPage.ElementAt(3));
            }

            pizzaDetailForm.ShowDialog();
        }

        public static void AddValues(NuestrasPizzas form)
        {
            try
            { 
            form.actualPage.Text = form.page.ToString();
            form.namePizza1.Text = form.pizzaPage.ElementAt(0).Nombre;
            form.namePizza2.Text = form.pizzaPage.ElementAt(1).Nombre;
            form.namePizza3.Text = form.pizzaPage.ElementAt(2).Nombre;
            form.namePizza4.Text = form.pizzaPage.ElementAt(3).Nombre;

            form.fotoPizza1.Image = Image.FromFile(form.pizzaPage.ElementAt(0).Foto);
            form.fotoPizza2.Image = Image.FromFile(form.pizzaPage.ElementAt(1).Foto);
            form.fotoPizza3.Image = Image.FromFile(form.pizzaPage.ElementAt(2).Foto);
            form.fotoPizza4.Image = Image.FromFile(form.pizzaPage.ElementAt(3).Foto);
             }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Algunos archivos no han sido encontrados");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha habido un error al cargar las pizzas");
            }
        }

        public static void RemoveValues(NuestrasPizzas form)
        {
            form.namePizza1.Text = "";
            form.namePizza2.Text = "";
            form.namePizza3.Text = "";
            form.namePizza4.Text = "";

            form.fotoPizza1.Image = Image.FromFile(@"C:\Users\angel\Desktop\Xquery\Pizzeria (1)\Pizzeria\food_cooking_meal_2-512.png");
            form.fotoPizza2.Image = Image.FromFile(@"C:\Users\angel\Desktop\Xquery\Pizzeria (1)\Pizzeria\food_cooking_meal_2-512.png");
            form.fotoPizza3.Image = Image.FromFile(@"C:\Users\angel\Desktop\Xquery\Pizzeria (1)\Pizzeria\food_cooking_meal_2-512.png");
            form.fotoPizza4.Image = Image.FromFile(@"C:\Users\angel\Desktop\Xquery\Pizzeria (1)\Pizzeria\food_cooking_meal_2-512.png");
        }

        public static void NextPage(NuestrasPizzas form)
        {       
            form.page += 1;
            RemoveValues(form);
            form.pizzaPage = form.pizzas.SelectPage(form.page);
            AddValues(form);
            CheckElements(form);
        }

        public static void PreviusPage(NuestrasPizzas form)
        {
            form.page -= 1;
            RemoveValues(form);
            form.pizzaPage = form.pizzas.SelectPage(form.page);
            AddValues(form);
            CheckElements(form);
        }

        public static void CheckElements(NuestrasPizzas form)
        {
            if (form.actualPage.Text == "0")
            {
                form.buttonPrev.Enabled = false;
            }
            if (form.pizzaPage.Count != 4)
            {
                form.buttonNext.Enabled = false;
            }
            else
            {
                form.buttonNext.Enabled = true;
            }
        }
    }
}
