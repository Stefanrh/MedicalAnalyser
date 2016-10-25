using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BodyAnalyser
    {
        // Given the weight and height of a person, return the BMI
        private double CalculateBMI(double heightInMeters, double weightInKilo)
        {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // Given the weight and height of a person, return a brief analysis
        // of the BMI of that person
        public void AnalyseBMI(double heightInMeters, double weightInKilo)
        {
            // The below code must be changed
            if(CalculateBMI(heightInMeters, weightInKilo) < 15)
            {
                Console.WriteLine("You are way too skinny!");
            }

            else if ((CalculateBMI(heightInMeters,weightInKilo) >= 15) && (CalculateBMI(heightInMeters, weightInKilo) < 22))
            {
                Console.WriteLine("You are a bit skinny");
            }

            else if ((CalculateBMI(heightInMeters, weightInKilo) >= 22) && (CalculateBMI(heightInMeters,weightInKilo) < 28))
            {
                Console.WriteLine("You are just fine!");
            }

            else if ((CalculateBMI(heightInMeters, weightInKilo) >= 28) && (CalculateBMI(heightInMeters, weightInKilo) < 35))
            {
                Console.WriteLine("You are a bit overweight!");
            }
            else if (CalculateBMI(heightInMeters, weightInKilo) >= 35)
            {
                Console.WriteLine("You are way too fat");
            }

            Console.WriteLine("All people are beautiful, YOU are beautiful!");

            ;
        }

    }
}
