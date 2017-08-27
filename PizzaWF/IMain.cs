using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    interface IMain
    {
       void AddPizza (object sender, EventArgs e);
       void NuestrasPizzas(object sender, EventArgs e);
       void Salir (object sender, EventArgs e);
    }
}
