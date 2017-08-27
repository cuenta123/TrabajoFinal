using Pizzeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
   
    public partial class AddPizza : Window, IAddPizza
    {
        List<Ingrediente> ingredients;
        public decimal baseprice = 5;


        public AddPizza()
        {
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
