using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the action to be performed:");
            Console.WriteLine("1- Addition\n2- Subtraction\n3- Multiplication\n4- Division\n5- Leave");
            Console.WriteLine("--------------");
            short operation = short.Parse(Console.ReadLine());
            float result = 0;
            string textOperation = "";

            switch (operation)
            {
                case 1:
                    result = Addition(v1,v2);
                    textOperation = "addition";
                    break;
                case 2:
                    result = Subtraction(v1,v2);
                    textOperation = "subtraction";
                    break;    
                case 3:
                    result = Multiplication(v1,v2);
                    textOperation = "multiplication";
                    break; 
                case 4:
                    result = Division(v1,v2);
                    textOperation = "division";
                    break; 

                case 5:
                    Console.WriteLine("The application is finished!");
                    System.Environment.Exit(0);
                    break; 
                default:
                    Console.Clear();
                    Console.WriteLine("Valor inválido!");
                    Console.WriteLine("You will be redirected to the beginning of the application!");
                    Console.WriteLine("--------------");
                    break;
            }

            Console.WriteLine($"The result of the {textOperation} is: "+ result);
            Console.ReadKey();
            Console.WriteLine("--------------");
        }
        static float Addition(float v1, float v2)
        {
            return v1+v2;
        }
        static float Subtraction(float v1, float v2)
        {
            return v1-v2;
        }
        static float Multiplication(float v1, float v2)
        {
            return v1*v2;
        }
            static float Division(float v1, float v2)
        {
            return v1/v2;
        }
    }
}