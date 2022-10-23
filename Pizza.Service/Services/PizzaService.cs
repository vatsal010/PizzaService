using Pizza.Service.Models;
using System.Collections.Generic;

namespace Pizza.Service.Services
{
    public class PizzaService : IPizzaService
    {
        public IEnumerable<MenuItem> GetDPizzaMenu()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { Id = 1, Name = "Burger Meal", ImageUrl = "/assets/food-1.jpg", Rating = 4, Prize = 9 });
            menuItems.Add(new MenuItem() { Id = 2, Name = "Veg Pizza", ImageUrl = "/assets/food-2.jpg", Rating = 3, Prize = 6 });
            menuItems.Add(new MenuItem() { Id = 3, Name = "Noodles", ImageUrl = "/assets/food-3.jpg", Rating = 4, Prize = 7 });
            menuItems.Add(new MenuItem() { Id = 4, Name = "Paneer Pizza", ImageUrl = "/assets/food-4.jpg", Rating = 4, Prize = 8 });
            return menuItems;
        }

        public IEnumerable<PizzaSauce> GetPizzaSauces()
        {
            var pizzaSauces = new List<PizzaSauce>();
            pizzaSauces.Add(new PizzaSauce() { Id = 1, Name = "marinara", ImageUrl = "/assets/sauces/sauce-1.jfif", Prize = 2 });
            pizzaSauces.Add(new PizzaSauce() { Id = 2, Name = "cheese", ImageUrl = "/assets/sauces/sauce-2.jfif", Prize = 2 });
            pizzaSauces.Add(new PizzaSauce() { Id = 3, Name = "ranch", ImageUrl = "/assets/sauces/sauce-3.jfif", Prize = 2 });
            return pizzaSauces;
        }

        public IEnumerable<PizzaSize> GetPizzaSize()
        {
            var pizzaSizes = new List<PizzaSize>();
            pizzaSizes.Add(new PizzaSize() { Id = 1, Name = "Small (9\")", ImageUrl = "/assets/pizza-size.jpg", Prize = 2 });
            pizzaSizes.Add(new PizzaSize() { Id = 2, Name = "Medium (11\")", ImageUrl = "/assets/pizza-size.jpg", Prize = 5 });
            pizzaSizes.Add(new PizzaSize() { Id = 3, Name = "Medium (11\")", ImageUrl = "/assets/pizza-size.jpg", Prize = 7 });
            return pizzaSizes;
        }

        public IEnumerable<Topping> GetPizzaToppings()
        {
            var toppings = new List<Topping>();
            toppings.Add(new Topping() { Id = 1, Name = "anchovy", ImageUrl = "/assets/toppings/anchovy.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 2, Name = "bacon", ImageUrl = "/assets/toppings/bacon.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 3, Name = "basil", ImageUrl = "/assets/toppings/basil.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 4, Name = "chili", ImageUrl = "/assets/toppings/chili.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 5, Name = "mozzarella", ImageUrl = "/assets/toppings/mozzarella.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 6, Name = "mushroom", ImageUrl = "/assets/toppings/mushroom.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 7, Name = "olive", ImageUrl = "/assets/toppings/olive.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 8, Name = "onion", ImageUrl = "/assets/toppings/onion.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 9, Name = "pepper", ImageUrl = "/assets/toppings/pepper.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 10, Name = "pepperoni", ImageUrl = "/assets/toppings/pepperoni.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 11, Name = "sweetcorn", ImageUrl = "/assets/toppings/sweetcorn.svg", Prize = 2 });
            toppings.Add(new Topping() { Id = 12, Name = "tomato", ImageUrl = "/assets/toppings/tomato.svg", Prize = 2 });
            return toppings;
        }
    }
}
