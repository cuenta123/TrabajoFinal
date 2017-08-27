using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using LinqToSql;
using Pizzeria.Models;

namespace Pizzeria
{

    public partial class VerPizza : Form
    {
        Pizza Pizza;
       
        public VerPizza(Pizza pizza)
        {
            Pizza = pizza;
            InitializeComponent();
        }
        
        public void VerPizza_Load(object sender, EventArgs e)
        {
            ViewMethodsVerPizza.LoadValues(this,Pizza);
        }

        public void submit_Click(object sender, EventArgs e)
        {
            ViewMethodsVerPizza.SubmitComment(this,Pizza);
        }
    }
}
