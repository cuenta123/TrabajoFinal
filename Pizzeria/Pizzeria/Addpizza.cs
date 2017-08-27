using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Addpizza : Form, IAddPizza
    {
        List<Ingrediente> ingredients;
        public decimal baseprice = 5;

        public Addpizza()
        {
            ingredients = LoadingIngredient();          
            InitializeComponent();
        }

        public List<Ingrediente> LoadingIngredient()
        {
            return ingredients = ViewMethodsAddPizza.LoadIngredients();
        }

        public void previewImages(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            } 
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Elige una imagen");
            }
            else
            {
                ViewMethodsAddPizza.CreatePizza(this);
            }
        }   

        public void btnrigth_Click(object sender, EventArgs e)
        {
            ViewMethodsAddPizza.AddItemsListBox(this);
        }
    }
}
