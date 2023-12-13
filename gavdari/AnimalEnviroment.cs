﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gavdari
{
    public class IAnimalEnvironment
    {
        public HealthParameter<int>TDS { get; set; }

        public HealthParameter<double> Temperature { get; set; }

        public HealthParameter<int> Density { get; set; }

        public HealthParameter<double> Decibel { get; set; }

        public HealthParameter<int> AQI { get; set; }

        public HealthParameter<int> Oxygen { get; set; }

        public DateTime Date { get; set; }
    }
}
