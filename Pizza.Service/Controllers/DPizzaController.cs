using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza.Service.Models;
using Pizza.Service.Services;
using System.Collections.Generic;

namespace Pizza.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DPizzaController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPizzaService _pizzaService;

        public DPizzaController(ILogger<WeatherForecastController> logger, IPizzaService pizzaService)
        {
            _logger = logger;
            _pizzaService = pizzaService;
        }

        /// <summary>
        /// Gets the D'Pizza menu items.
        /// </summary>
        /// <returns></returns>
        [HttpGet("Getdpizzamenu")]
        public IEnumerable<MenuItem> GetDPizzaMenu()
        {
            return _pizzaService.GetDPizzaMenu();
        }

        /// <summary>
        /// Gets all the pizza sizes.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getpizzasize")]
        public IEnumerable<PizzaSize> GetPizzaSize()
        {
            return _pizzaService.GetPizzaSize();
        }

        /// <summary>
        /// Gets all the pizza toppings.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getpizzatoppings")]
        public IEnumerable<Topping> GetPizzaToppings()
        {
            return _pizzaService.GetPizzaToppings();
        }

        /// <summary>
        /// Gets all the pizza sauces.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getpizzasauces")]
        public IEnumerable<PizzaSauce> GetPizzaSauces()
        {
            return _pizzaService.GetPizzaSauces();
        }
    }
}
