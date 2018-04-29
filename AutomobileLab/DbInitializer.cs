using AutomobileLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileLab
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.

            var Autos = new Auto[]
            {
                new Auto{ ModelName = "BMW X5", ModelType = "Sedan", BackPackType = 1, Price = 38.020M, ProductionYear = Convert.ToDateTime("2012-03-01")},
                new Auto{ ModelName = "Audi S3", ModelType = "Pickup", BackPackType = 2, Price = 27.000M, ProductionYear = Convert.ToDateTime("2012-03-01")},
                //new Auto{ ModelName = "Bogdan", ModelType = "Sedan", BackPackType = 3, Price = 7.010M, ProductionYear = Convert.ToDateTime("2012-03-01")}
            };
            foreach(var item in Autos)
            {
                context.Autos.Add(item);
            }
            context.SaveChanges();
        }
    }
}
