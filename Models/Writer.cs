using FitnessCalculator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Models
{
    public class Writer : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
