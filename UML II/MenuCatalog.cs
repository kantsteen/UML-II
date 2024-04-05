using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_II
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }
        
        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void PrintMenu()
        {
            foreach (Pizza p in _pizzas)
            {
                Console.WriteLine(p);
            }

        }

        public Pizza Read(int pizzaID)
        {
            foreach (Pizza pizza in _pizzas)
            {
                if (pizza.Number == pizzaID)
                {
                    return pizza;
                }
            }
            return null;
        }


        public Pizza SearchPizza(string searchCriteria)
        {
            foreach (Pizza pizza in _pizzas)
            {
                if (pizza.Name.Equals(searchCriteria, StringComparison.OrdinalIgnoreCase))
                {
                    return pizza;
                }
            }
            return null;
        }
        public void Update(Pizza updatedPizza)
        {
            foreach (Pizza pizza in _pizzas)
            {
                if (pizza.Name == updatedPizza.Name)
                {
                    pizza.Name = updatedPizza.Name;
                    pizza.Price = updatedPizza.Price;
                    break;
                }
            }
        }

        public void Delete(int deletedPizza)
        {
            foreach (Pizza pizza in _pizzas.ToList())
            {
                if (pizza.Number.Equals(deletedPizza))
                {
                    _pizzas.Remove(pizza);
                }
            }
        }
    }
}
