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
   
    public partial class PizzaDetail : Window, I
    {
        public PizzaDetail()
        {
            InitializeComponent();
        }

        private void VerPizza_Load(object sender, EventArgs e)
        {
            ViewMethodsVerPizza.LoadValues(this, Pizza);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            ViewMethodsVerPizza.SubmitComment(this, Pizza);
        }

    }
}
