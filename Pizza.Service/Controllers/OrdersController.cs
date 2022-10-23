using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza.Service.Models;
using Pizza.Service.Services;
using System.Collections.Generic;

namespace Pizza.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOrderService _orderService;

        public OrdersController(ILogger<WeatherForecastController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        /// <summary>
        /// Gets the D'Pizza menu items.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrder([FromBody]OrderRequest orderRequest)
        {
            var response = _orderService.CreateOrder(orderRequest);
            return Ok(response);
        }
    }
}
