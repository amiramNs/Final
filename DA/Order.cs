using System;
using System.Collections.Generic;
using System.Text;

namespace DA
{
    public class Order
    {
        public Order(List<OrderDetail> orderDetails)
        {
            OrderDetails = orderDetails;
        }

        public int Id { get; private set; }
        public List<OrderDetail> OrderDetails { get; private set; }
        public decimal PriceTotule => Price();
        public string DescriptionOrder => Description();
        private decimal Price()
        {
            var totalAmount = 0M;
            foreach (var orderDetail in OrderDetails)
            {
                totalAmount += (orderDetail.FoodType.PriceFood) * orderDetail.Count;
            }
            return totalAmount;
        }
        private string Description()
        {
            var result = "";
            foreach (var orderdetail in OrderDetails)
            {
                result += orderdetail.Count.ToString() + " " + orderdetail.FoodType.NameFood + "   ";
            }
            return result;
        }
        private Order()
        {}
    }
}
