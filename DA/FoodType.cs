using System;

namespace DA
{
    public class FoodType
    {
        public FoodType(string name, decimal price)
        {
            if (name == "" || price == 0)
            {
                throw new Exception("!!وروردی نامعتبر است");
            }
            NameFood = name;
            PriceFood = price;
        }
        public int Id { get; private set; }
        public string NameFood { get; private set; }
        public decimal PriceFood { get; private set; }
        private FoodType()
        { }
    }
}
