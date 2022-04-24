using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DA
{
    public class RiposiroryOrder
    {
        public List<Order> GetOrders()
        {
            using var context = new FinalContext();
            return context.Orders.Include(p => p.OrderDetails).ThenInclude(p => p.FoodType).ToList();
        }
        public Order GetOrder(int id)
        {
            using var context = new FinalContext();
            return context.Orders.Find(id);
        }
        public void AddOrder(Order order)
        {
            List<FoodType> foodTypes = new List<FoodType>();
            using var context = new FinalContext();
            foreach (var orderDetail in order.OrderDetails)
            {
                foodTypes.Add(orderDetail.FoodType);
                orderDetail.FoodType = null;
            }
            context.Orders.Add(order);
            for (int i = 0; i < order.OrderDetails.Count; i++)
            {
                order.OrderDetails[i].FoodType = foodTypes[i];
            }
            context.SaveChanges();
        }
    }
}
