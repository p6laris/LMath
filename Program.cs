using System;

namespace MyProgram
{
    
    class Program
    {
        static void Main()
        {
            Menue();
        }
        static void Menue()
        {
            int choice = 0;
            Logic_Math.LogicMath lm = new Logic_Math.LogicMath();
            Console.WriteLine("Welcome to Truth Table for connectives");
            Console.WriteLine("**************************************");
            do
            {
                
                
                Console.WriteLine("1.AND");
                Console.WriteLine("2.OR");
                Console.WriteLine("3.Negation");
                Console.WriteLine("4.Exit");

                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        lm.connective = '^';
                        lm.AND();
                        break;
                    case 2:
                        lm.connective = 'v';
                        lm.OR();
                        break;
                    case 3:
                        lm.connective = '~';
                        lm.Negation();
                        break;
                    default:
                        Console.WriteLine("Sorry the choice invalid.");
                        break;
                }
               
            } while (choice != 4);
        }
    }
  
     
}