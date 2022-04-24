 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class RipositoryFoodType
    {
        public List<FoodType> GetFoods()
        {
            using var context = new FinalContext();
            return context.FoodTypes.ToList();
        }
        public FoodType GetFood(string name)
        {
            using var context = new FinalContext();
            var food = context.FoodTypes.FirstOrDefault(p=>p.NameFood==name);
            return food;
        }
        public void AddFood(FoodType foodType)
        {
            using var context = new FinalContext();
            context.FoodTypes.Add(foodType);
            context.SaveChanges();
        }

    }
}
