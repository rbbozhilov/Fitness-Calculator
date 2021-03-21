using FitnessCalculator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Models
{
    public class Calculator : ICalculator
    {

        private double kg = 0;
        private double pr = 0;
        private double kl = 0;
        private double ft = 0;
        private double vug = 0;
        private double vg = 0;
        private double prConst = 0;
        private double klConst = 0;


        public Calculator(Person person)
        {
            this.kg = person.Weight;
        }


        public void IncreaseMuscleFast()
        {

            this.prConst = 3;
            this.klConst = 37.5;
            Calculation(prConst, klConst);


        }

        public void IncreaseMuscleSlow()
        {

            this.prConst = 2.6;
            this.klConst = 35;

            Calculation(prConst, klConst);

        }

        public void LoseWeightFast()
        {

            this.prConst = 1.5;
            this.klConst = 28;

            Calculation(prConst, klConst);

        }

        public void LoseWeightSlow()
        {
            this.prConst = 1.8;
            this.klConst = 29;

            Calculation(prConst, klConst);

        }

        public void WeightMaintenance()
        {
            this.prConst = 2;
            this.klConst = 30;

            Calculation(prConst, klConst);

        }

        private void Calculation(double prConst, double klConst)
        {
            this.pr = this.kg * prConst;
            this.kl = klConst * this.kg;
            this.vug = (this.kl * 0.3) + (this.pr * 4);
            this.vg = (this.kl - this.vug) / 4;
            this.ft = (this.kl * 0.3) / 9;
        }


        public override string ToString()
        {
            return $"Protein = {this.pr:F2}" + Environment.NewLine + $"Carbohydrates = {this.vg:F2}" + Environment.NewLine + $"Calories = {this.kl:F2}" + Environment.NewLine + $"Fat = {this.ft:F2}";

        }


    }
}
