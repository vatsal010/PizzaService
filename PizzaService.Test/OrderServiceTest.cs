using Moq;
using Pizza.Service.Models;
using Pizza.Service.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace PizzaService.Test
{
    public class OrderServiceTest
    {
        [Fact]
        public void CreateOrder_SmallPizza_Test()
        {
            //Setup
            var pizzaService = new OrderService();

            // Action
            var result = pizzaService.CreateOrder(GetOrder_Small_ExtraCheese_MockData());

            // Assert
            Assert.NotNull(result);
            Assert.Equal(16, result.Prize);
        }

        [Fact]
        public void CreateOrder_MediumPizza_Test()
        {
            //Setup
            var pizzaService = new OrderService();

            // Action
            var result = pizzaService.CreateOrder(GetOrder_Medium_MockData());

            // Assert
            Assert.NotNull(result);
            Assert.Equal(13, result.Prize);
        }

        private OrderRequest GetOrder_Small_ExtraCheese_MockData()
        {
            var orderRequest = new OrderRequest();
            orderRequest.AddExtraCheese = true;

            orderRequest.PizzaSize = new PizzaSize() { Id = 1, ImageUrl = "", Name = "Small", Prize = 3 };
            orderRequest.PizzaSauce = new PizzaSauce() { Id = 1, ImageUrl = "", Name = "marinara", Prize = 2 };

            orderRequest.Toppings = new List<Topping>();
            orderRequest.Toppings.Add(new Topping() { Id = 1, ImageUrl = "", Name = "mushroom", Prize = 2 });
            orderRequest.Toppings.Add(new Topping() { Id = 1, ImageUrl = "", Name = "onion", Prize = 2 });
            orderRequest.Toppings.Add(new Topping() { Id = 1, ImageUrl = "", Name = "sweetcorn", Prize = 2 });

            orderRequest.Prize = 15;
            return orderRequest;
        }

        private OrderRequest GetOrder_Medium_MockData()
        {
            var orderRequest = new OrderRequest();
            orderRequest.AddExtraCheese = false;

            orderRequest.PizzaSize = new PizzaSize() { Id = 1, ImageUrl = "", Name = "Medium", Prize = 5 };
            orderRequest.PizzaSauce = new PizzaSauce() { Id = 1, ImageUrl = "", Name = "marinara", Prize = 2 };

            orderRequest.Toppings = new List<Topping>();
            orderRequest.Toppings.Add(new Topping() { Id = 1, ImageUrl = "", Name = "mushroom", Prize = 2 });
            orderRequest.Toppings.Add(new Topping() { Id = 1, ImageUrl = "", Name = "onion", Prize = 2 });
            orderRequest.Toppings.Add(new Topping() { Id = 1, ImageUrl = "", Name = "sweetcorn", Prize = 2 });

            orderRequest.Prize = 13;
            return orderRequest;
        }
    }
}
