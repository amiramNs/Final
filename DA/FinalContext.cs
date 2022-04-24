using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DA
{
    public class FinalContext : DbContext
    {
        public DbSet<FoodType> FoodTypes { get; private set; }
        public DbSet<Order> Orders { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\Final\DA\FinalDb.mdf;Integrated Security=True");
        } 
    }
}
