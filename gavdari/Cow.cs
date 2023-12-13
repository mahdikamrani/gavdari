using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gavdari
{
    public sealed class Cow : Animal
    {
        
        public int CowsNumber;

        public Cow(int MaxLife,
                   bool Gender,
                   double Weight,
                   List<IAnimalEnvironment> Environments,
                   List<Product> Products,
                   List<Cost> Costs)
        {
            CowsNumber++;
            this.ID = CowsNumber;
            this.MaxLife = MaxLife;
            this.Gender = Gender;
            this.Weight = Weight;
            this.Environments = Environments;
            this.Products = Products;
            this.Costs = Costs;
            BirthDate = DateTime.Today;

            Name = $"C{(this.Gender ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}{ID}";
        }


        public int ID { get; init; }

        public string Name { get; init; }

        public DateTime BirthDate { get; init; }

        public int MaxLife { get; init; }

        public List<IAnimalEnvironment> Environments { get; set; }

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }

        public double Weight { get; set; }

        public bool Gender { get; set; }

        bool female = true;
 

     

        public override int TimeToDie()
        {
            double zendegimojadd = (MaxLife * 365) - Life();
            return (int)(zendegimojadd / 365);
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
