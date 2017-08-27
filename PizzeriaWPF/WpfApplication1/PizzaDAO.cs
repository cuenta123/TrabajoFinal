using LinqToSqlStringBuilder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WpfApplication1;

namespace Pizzeria
{
   public class PizzaDAO
    {
       int maxElementsPage = 4;
       int maxPages = 10;
       int maxResults = 40;
       int page; 
       List<Pizza> pizzaList = null;

       public PizzaDAO()
        {
            pizzaList = new List<Pizza>();
        }

        public List<Pizza> SelectPage(int Page)
        {
            page = Page;
            if (pizzaList.Count == 0)
            {
                SelectLastPizzas();
            }
            return PullSelectedPizzas(pizzaList);
        }

        private void SelectLastPizzas()
        {
            MydbContex db = new MydbContex();
            Pizza p = new Pizza();
            int contador = 0;
            foreach (var pizza in db.Pizza)
            {
                if (contador == maxResults)
                {
                    break;
                }
                pizzaList.Add(pizza);
                contador++;
            }
        }

     
        private List<Pizza> PullSelectedPizzas(List<Pizza> pizzaList)
        {
           int initalCount = 0; 
           int contador = page * maxPages;
           List<Pizza> selectPizzas = new List<Pizza>(); 
           foreach (var pizza in pizzaList)
            {
                if(contador== page * maxPages + maxElementsPage)
                {
                   break;
                }
                if (initalCount >= contador )
                {
                    selectPizzas.Add(pizza);
                    contador++;
                }  
                 
                initalCount++;
            }
            return selectPizzas;
        } 
        
    }
}
