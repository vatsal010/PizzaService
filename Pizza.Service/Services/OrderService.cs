using Pizza.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Service.Services
{
    public class OrderService : IOrderService
    {
        public OrderRequest CreateOrder(OrderRequest orderRequest)
        {
            orderRequest.Id = Guid.NewGuid();
            orderRequest.Prize = ValidateOrderPrize(orderRequest);
            return orderRequest;
        }

        private int ValidateOrderPrize(OrderRequest orderRequest)
        {
            var prize = 0;
            if (orderRequest.AddExtraCheese)
            {
                prize = prize + 5;
            }
            prize = prize + orderRequest.PizzaSauce.Prize;
            prize = prize + orderRequest.PizzaSize.Prize;
            foreach (var topping in orderRequest.Toppings)
            {
                prize = prize + topping.Prize;
            }

            return prize;
        }
    }
}
