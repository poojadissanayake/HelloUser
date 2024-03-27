using System;
using SplashKitSDK;
#nullable disable

namespace HelloUser
{
    public class Program
    {
        public static void Main()
        {
            string name;
            string inputHeight;
            string inputWeight;
            int heightInCM;
            double weightInKG;
            double heightInMeters;
            double height;
            double bmi;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.WriteLine("Enter yout height(cm) and weight(Kg): ");
            inputHeight = Console.ReadLine();
            inputWeight = Console.ReadLine();
            heightInCM = Convert.ToInt32(inputHeight);
            heightInMeters = heightInCM / 100.0;
            weightInKG = Convert.ToDouble(inputWeight);

            Console.WriteLine($"Your height is {heightInMeters} meters");
            Console.WriteLine($"Your weight is {weightInKG} kg");

            // calculating bmi 
            height = heightInMeters * heightInMeters;
            bmi = weightInKG / height;

            Console.WriteLine($"Your BMI is {bmi}");
        }
    }
}
