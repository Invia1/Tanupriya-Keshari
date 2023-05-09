using System;


namespace Fact_Fbn_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reply;
            do{
                label:
            Console.WriteLine("Enter 1 for factorial: \nEnter 2 for fibonacci series: \nEnter 3 for prime number:");
            int n=Convert.ToInt32(Console.ReadLine());
            
            switch (n)
            {
                    case 1:
                    {
                        int num,fact=1;
        
                        Console.WriteLine("Enter n : ");
                        num=int.Parse(Console.ReadLine());
                        for(int i=1;i<num;i++)
                        {
                            fact=fact*i;
                        }
                        Console.WriteLine("Factotial is:"+fact);
                        Console.ReadLine();

                    break;
                    }

                    case 2:
                    {
                        int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
                        Console.Write("Enter the number of elements to Print : ");
                        numberOfElements = int.Parse(Console.ReadLine());
                        if(numberOfElements < 2)
                        {
                            Console.Write("Please Enter a number greater than two");
                        }
                        else
                        {
                            //First print first and second number
                            Console.Write(firstNumber + " " + SecondNumber + " ");
                            //Starts the loop from 2 because 0 and 1 are already printed
                            for(int i = 2; i < numberOfElements; i++)
                            {
                                nextNumber = firstNumber + SecondNumber;
                                Console.Write(nextNumber + " ");
                                firstNumber = SecondNumber;
                                SecondNumber = nextNumber;
                            }
                        }
            
                        Console.ReadKey();

                    break;
                    }
                case 3:
                    {

                        int num1;

                        Console.WriteLine("Accept number:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 0 || num1 == 1)
                        {
                        Console.WriteLine(num1 + " is not prime number");
                        Console.ReadLine();
                        }
                    else
                    {
                        for (int a = 2; a <= num1 / 2; a++)
                        {
                        if (num1 % a == 0)
                        {
                            Console.WriteLine(num1 + " is not prime number");
                        }

                        }
                        Console.WriteLine(num1 + " is a prime number");
                        Console.ReadLine();
                    }

                    break;
                    }
                    default:
                    {
                        Console.WriteLine("please enter a valid value");
                        goto label;
                        
                    }
                    }
                    Console.WriteLine("if you want to restart the program than type 'yes'");
                    reply = Console.ReadLine();
                    } while (reply.ToLower() == "yes");

                   
            
           
            Console.ReadLine();
        }
    }
}