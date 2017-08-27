using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    interface IAddPizza
    {    
         List<Ingrediente> LoadingIngredient();
         void previewImages(object sender, EventArgs e);
         void button2_Click(object sender, EventArgs e);
         void btnrigth_Click(object sender, EventArgs e);
    }
}
