using Pizza.Service.Models;
using System.Collections.Generic;

namespace Pizza.Service.Services
{
    public interface IPizzaService
    {
        IEnumerable<MenuItem> GetDPizzaMenu();
        IEnumerable<PizzaSize> GetPizzaSize();
        IEnumerable<Topping> GetPizzaToppings();
        IEnumerable<PizzaSauce> GetPizzaSauces();
    }
}
