using FitnessCalculator.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Models
{
    public class Reader : IReader
    {

        public string ReadLine()
        {
            string text = Console.ReadLine();
            return text;
        }
    }
}
