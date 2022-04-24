using System;
using System.Collections.Generic;
using System.Text;

namespace DA
{
    public class OrderDetail
    {
        public OrderDetail(FoodType food, int count)
        {
            if(count==0)
            {
                throw new Exception("!!ورودی نامعتبر است");
            }
            this.FoodType = food;
            Count = count;
        }
        public int Id { get; private set; }
        public FoodType FoodType { get; set; }
        public int Count { get; private set; }
        private OrderDetail()
        {}
    }
}
