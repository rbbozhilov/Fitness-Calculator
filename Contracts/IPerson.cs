using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Contracts
{
    public interface IPerson
    {

        public string Name { get;  }
        public int Age { get; }
        public double Weight { get; }



    }
}
