using Pizza.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Service.Services
{
    public interface IOrderService
    {
        OrderRequest CreateOrder(OrderRequest orderRequest);
    }
}
