using FitnessCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Contracts
{
    public interface ICalculator
    {

        void IncreaseMuscleFast();
        void IncreaseMuscleSlow();
        void LoseWeightFast();
        void LoseWeightSlow();
        void WeightMaintenance();


    }
}
