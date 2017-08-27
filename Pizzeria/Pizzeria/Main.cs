using LinqToSql;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Salir(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NuestrasPizzas(object sender, EventArgs e)
        {         
            NuestrasPizzas fm = new NuestrasPizzas();
            fm.ShowDialog();
        }

        private void AddPizza (object sender, EventArgs e)
        {
            Addpizza fm = new Addpizza();
            fm.ShowDialog();
        }

    }
}
