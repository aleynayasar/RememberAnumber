using System;

namespace RememberANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Are you ready for the game ? ");
            Console.WriteLine(" \n\a***** Let's go *****");
            Console.ReadLine();
            int answer;
            do
            {
                int number;

                do
                {
                    Console.Write("Enter three digit number : ");
                    number = int.Parse(Console.ReadLine());

                } while (number < 100 || number > 999);
                Console.WriteLine("Reverse the number you are holding");
                Console.ReadLine();
                Console.WriteLine("Subtract the smaller from the larger number");
                Console.ReadLine();
                Console.WriteLine("\aWhat is the last digit of the result? ");
                int endNumber = int.Parse(Console.ReadLine());
                switch (endNumber)
                {
                    case 1:
                        Console.WriteLine("The result of the operation : 891 . ");
                        break;
                    case 2:
                        Console.WriteLine("The result of the operation : 792 . ");
                        break;
                    case 3:
                        Console.WriteLine("The result of the operation : 693 . ");
                        break;
                    case 4:
                        Console.WriteLine("The result of the operation : 594 . ");
                        break;
                    case 5:
                        Console.WriteLine("The result of the operation : 495 . ");
                        break;
                    case 6:
                        Console.WriteLine("The result of the operation : 396 . ");
                        break;
                    case 7:
                        Console.WriteLine("The result of the operation : 297 . ");
                        break;
                    case 8:
                        Console.WriteLine("The result of the operation : 198 .");
                        break;
                    case 9:
                        Console.WriteLine("The result of the operation : 099 . ");
                        break;
                    case 0:
                        Console.WriteLine("The result of the operation : 000 . ");
                        break;
                    default:
                        Console.WriteLine("Make sure you entered the last digit correctly!!");
                        break;
                }
                Console.WriteLine("Do you want to try again? if yes, press 0. ");
                answer = int.Parse(Console.ReadLine());
            } while (answer==0);

            Console.ReadKey();
        }
    }
}
