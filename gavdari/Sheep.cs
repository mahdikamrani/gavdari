using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gavdari
{
    public class Sheep : Animal
    {
        public static int SheepsNumber;

        public Sheep(int MaxLife,
                   bool Gender,
                   double Weight,
                   
                   List<Product> Products,
                   List<Cost> Costs)
        {
            SheepsNumber++;
            this.ID = SheepsNumber;
            this.MaxLife = MaxLife;
            this.Gender = Gender;
            this.Weight = Weight;
            this.Environments = Environments;
            this.Products = Products;
            this.Costs = Costs;
            BirthDate = DateTime.Today;

            Name = $"S{(this.Gender ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}{ID}";
        }

        public int ID { get; init; }

        public string Name { get; init; }

        public DateTime BirthDate { get; init; }

        public int MaxLife { get; init; }

        bool female = true;

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }

        public double Weight { get; set; }

        public bool Gender { get; set; }
        public override int TimeToDie()
        {
            double  zendgimojadd= (MaxLife * 365) - Life();
            return (int)(zendgimojadd / 365);
        }

        public override double KillPriority()
        {
            double alfa = ((TimeToDie()) / MaxLife);
            if (female == true)
                return alfa + 0 / 1;
            else
                return 1 - alfa;


        }

        public override decimal CostPerDay()
        {
            decimal TotalCost = 0;
            foreach (Cost Cost in Costs)
            {
                TotalCost += (decimal)Cost.Price * (decimal)Cost.DailyUsage;
            }
            return TotalCost;
        }

        public override decimal IncomePerDay()
        {
            decimal TotalIncome = 0;
            foreach (Product Product in Products)
            {
                TotalIncome += (decimal)Product.Price + (decimal)Product.DailyProduce;
            }
            return TotalIncome;
        }

        public override string ToString() =>
            $"Name: {Name} BirthDate: {BirthDate} Age: {Math.Round((double)Life() / 365, 0)}";

        public override decimal MeatIncome(decimal MeatPrice) => (decimal)Weight * MeatPrice;




    }
}
