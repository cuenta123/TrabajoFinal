using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    interface INuestrasPizzas
    {
        void PizzaDetail(object sender, EventArgs e);
        void NuestrasPizzas_Load(object sender, EventArgs e);
        void agregateValueComponents();
        void RemoveValues();
        void buttonNext_Click(object sender, EventArgs e);
        void buttonPrev_Click(object sender, EventArgs e);
    }
}
