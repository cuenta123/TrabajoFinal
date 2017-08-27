using LinqToSql;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    static class ViewMethodsAddPizza
    {

        public static List<Ingrediente> LoadIngredients()
        {
            MydbContex db = new MydbContex();
            return db.Ingrediente.ToList();
        }


        public static void CreatePizza(Addpizza form)
        {
            if (form == null)
            {
                throw new Exception("formulario addpizza nulo");
            }

            String Ingredient = GenerateStringPizzaIngredient(form);
            CalculatePrice(form);
            GeneratePizza(form,Ingredient);
        }

        private static String GenerateStringPizzaIngredient(Addpizza form)
        {
            int numberElements;
            String ingr;
            List<Ingrediente> ingredientList = LoadIngredients();
            StringBuilder totalIngredient = new StringBuilder();

            numberElements = form.IngredientsText.Items.Count;

            for (int i = 0; i < numberElements; i++)
            {
                ingr = form.IngredientsText.Items[i].ToString();
                totalIngredient.Append(ingr);
                totalIngredient.Append(',');
            }
            return totalIngredient.ToString();
        }

        private static void CalculatePrice(Addpizza form)
        {
            var ingredientList = LoadIngredients();
            int numberElements = form.IngredientsText.Items.Count;

            for (int i = 0; i < numberElements; i++)
            {
                String ingr = form.IngredientsText.Items[i].ToString();
                var ingredientPrice = ingredientList.Where(num => num.Nombre == ingr).Select(num => num.Precio).ElementAt(0);
                form.baseprice += ingredientPrice;
            }
        }

        private static void GeneratePizza(Addpizza form, String Ingredient)
        {
            Pizza p = new Pizza() { Id = Guid.NewGuid(), Nombre = form.nombreText.Text, Foto = form.openFileDialog1.FileName, Precio = form.baseprice,Ingredientes = Ingredient  };
            GenericDaoEntityFramework gdao = new GenericDaoEntityFramework();
            gdao.InsertSQL(Generic.ToGeneric(p));
            MessageBox.Show("Su pizza ha sido añadida");
            ClearValues(form);
        }

        public static void AddItemsListBox(Addpizza form)
        {
            int index = form.comboBox1.SelectedIndex;
            string item = form.comboBox1.Items[index].ToString();
            form.IngredientsText.Items.Add(item);
        }

        public static void ClearValues (Addpizza form)
        {
            form.nombreText.Text = "";
            form.priceText.Text = "5";
            form.IngredientsText.Items.Clear();
            form.pictureBox1.Image = null;
        }
    }
}
