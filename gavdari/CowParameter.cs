using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gavdari
{
    public class CowParameter : ICowParameter
    {
        public HealthParameter<int> TimeToStand { get; set; }

        public HealthParameter<int> TimeToDie { get; set; }

        public HealthParameter<int> TimeToRelax { get; set; }

        public HealthParameter<int> NumberOfMeals { get; set; }

        public HealthParameter<int> NumberOfMilkProduction { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
