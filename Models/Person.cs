using FitnessCalculator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Models
{
    public class Person : IPerson
    {

        private string name;
        private int age;
        private double weight;

        public Person(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {

                if (value.Length < 2 || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Your name must be at least 2 letters.");
                }

                this.name = value;

            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return $"Hello , {this.Name} your results are:" + Environment.NewLine;
        }

    }
}
