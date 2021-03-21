using FitnessCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCalculator.Core
{
    public class Engine
    {
        private const string press = "Your choice";
        private const string personName = "Write your name (the name must contains at least 2 letters!) : ";
        private const string personAge = "Write your age : ";
        private const string personWeight = "Write your weight : ";
        private const string wrongChoice = "Some of your input is not correct, try again please !";
        private Writer writer;
        private Reader reader;

        public Engine()
        {
            writer = new Writer();
            reader = new Reader();
        }

        public void Run()
        {

            EngineLogic();



        }

        private int MainMenuChoice()
        {

            int choice = 0;

            writer.WriteLine("Press 1 for Increase Muscle Mass");
            writer.WriteLine("Press 2 for Lose weight");
            writer.WriteLine("Press 3 for Weight Maintenance");
            writer.WriteLine(press);
            choice = int.Parse(reader.ReadLine());

            return choice;
        }

        private int IncreaseMuscleMenuChoice()
        {
            int choice = 0;

            writer.WriteLine("Press 1 for FAST Increase Muscle Mass");
            writer.WriteLine("Press 2 for SLOW Increase Muscle Mass");
            writer.WriteLine(press);
            choice = int.Parse(reader.ReadLine());

            return choice;
        }

        private int WeightLoseMenuChoice()
        {
            int choice = 0;

            writer.WriteLine("Press 1 for FAST Weight Loss");
            writer.WriteLine("Press 2 for SLOW Weight Loss");
            writer.WriteLine(press);
            choice = int.Parse(reader.ReadLine());


            return choice;
        }



        private Person CreatingPerson()
        {

            Person person = null;
            string name = string.Empty;
            int age = 0;
            double weight = 0;

            try
            {
                writer.WriteLine(personName);
                name = reader.ReadLine();
                writer.WriteLine(personAge);
                age = int.Parse(reader.ReadLine());
                writer.WriteLine(personWeight);
                weight = double.Parse(reader.ReadLine());

            }

            catch (Exception ex)
            {
                writer.WriteLine(ex.Message);
            }


            try
            {
                person = new Person(name, age, weight);
            }

            catch (ArgumentException ae)
            {
                writer.WriteLine(ae.Message);
            }

            return person;
        }


        private void EngineLogic()
        {
            writer.WriteLine("Welcome to Fitness calculator!");
            writer.WriteLine("");
            writer.WriteLine("Please follow the steps");
            writer.WriteLine("");
            Person person = CreatingPerson();
            Calculator calculator = null;

            if (person == null)
            {
                writer.WriteLine(wrongChoice);
                Environment.Exit(0);
            }
            else
            {

                calculator = new Calculator(person);

                switch (MainMenuChoice())
                {
                    case 1:
                        {

                            switch (IncreaseMuscleMenuChoice())
                            {

                                case 1:
                                    {

                                        calculator.IncreaseMuscleFast();

                                        break;
                                    }

                                case 2:
                                    {

                                        calculator.IncreaseMuscleSlow();

                                        break;
                                    }
                                default:
                                    {
                                        writer.WriteLine(wrongChoice);
                                        Environment.Exit(0);
                                        break;
                                    }
                            }

                            break;
                        }

                    case 2:
                        {
                            switch (WeightLoseMenuChoice())
                            {

                                case 1:
                                    {
                                        calculator.LoseWeightFast();
                                        break;
                                    }

                                case 2:
                                    {
                                        calculator.LoseWeightSlow();
                                        break;
                                    }
                                default:
                                    {
                                        writer.WriteLine(wrongChoice);
                                        Environment.Exit(0);
                                        break;
                                    }
                            }

                            break;
                        }

                    case 3:
                        {
                            calculator.WeightMaintenance();
                            break;
                        }

                    default:
                        {

                            writer.WriteLine(wrongChoice);
                            Environment.Exit(0);
                            break;
                        }

                }

            }


            writer.WriteLine(person.ToString());
            writer.WriteLine(calculator.ToString());

        }

    }
}
