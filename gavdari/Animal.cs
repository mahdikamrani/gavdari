using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gavdari
{
    public abstract class Animal
    {
        
        
            public int ID { get; init; }

            public string Name { get; init; }

            public DateTime BirthDate { get; init; }

            public int MaxLife { get; init; }

            public List<IAnimalEnvironment> Environments { get; set; }

            public List<Product> Products { get; set; }

            public List<Cost> Costs { get; set; }

            public double Weight { get; set; }

            public bool Gender { get; set; }

            public abstract double AverageStressFactor(IAnimalEnvironment Environment);

            public abstract int Life();

            public abstract int TimeToDie();

            public abstract double KillPriority();

            public abstract decimal CostPerDay();

            public abstract decimal IncomePerDay();

            public abstract decimal MeatIncome(decimal MeatPrice);
        


    }
}
