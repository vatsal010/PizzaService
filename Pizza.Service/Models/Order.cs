using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Service.Models
{
    public class OrderRequest
    {
        public Guid Id { get; set; }
        public float Prize { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaSauce PizzaSauce { get; set; }
        public List<Topping> Toppings { get; set; }
        public bool AddExtraCheese { get; set; }
    }
}
