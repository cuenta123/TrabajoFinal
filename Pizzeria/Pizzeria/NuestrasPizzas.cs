using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class NuestrasPizzas : Form, INuestrasPizzas
    {
      public PizzaDAO pizzas;
      public List<Pizza> pizzaPage;
      public int page;

        public NuestrasPizzas()
        {
            InitializeComponent();  
        }

        public void PizzaDetail(object sender, EventArgs e) 
        {
            MethodViewNuestrasPizzas.VerPizza(this,sender);
        }

        public void NuestrasPizzas_Load(object sender, EventArgs e)
        {
            page = 0;
            pizzas = new PizzaDAO();
            pizzaPage = pizzas.SelectPage(page);
            MethodViewNuestrasPizzas.CheckElements(this);
            agregateValueComponents();
        }

        public void agregateValueComponents()
        {  
            MethodViewNuestrasPizzas.AddValues(this);
        }

        public void RemoveValues()
        {
            MethodViewNuestrasPizzas.RemoveValues(this);
        }

        public void buttonNext_Click(object sender, EventArgs e)
        {
            MethodViewNuestrasPizzas.NextPage(this);
        }

        public void buttonPrev_Click(object sender, EventArgs e)
        {
            MethodViewNuestrasPizzas.PreviusPage(this);
        }
    }
}
