using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
     class swtchCase
    {
        public int fibonacci_series(int n)
        {
            if (n == 0 || n==1)
            {
                return n;
            }
            else
            {
                return fibonacci_series(n - 1) + fibonacci_series(n - 2);
            }
            
        }
        public void prime(int n)

        {

             int a = 0;
            if (n > 1)
            {
                
                for (int i = 2; i < n; i++)
                {

                    if (n % i == 0)
                    {
                        ++a;
                        break;
                    }

                }
                if (a == 0 && a != 1)
                {
                    Console.WriteLine($"{n} is prime number");

                }
                else
                {
                    Console.WriteLine($"{n} is not prime number");
                }



            }
            



        }
        public int factorial(int n )
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;
            }

        }
        public static void Main()
        {
            var obj = new swtchCase();

            while(true)
            {
                Console.WriteLine("choose one option ");
                Console.WriteLine("1. fibonacci series ");
                Console.WriteLine("2. factorial ");
                Console.WriteLine("3. prime number");
                
                Console.WriteLine("\n\n");
                Console.WriteLine("enter your choice");


                int  num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("enter number : ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(obj.fibonacci_series(i));

                        }

                        break;

                    case 2:

                        Console.WriteLine("enter number grater than 0 : ");
                        int s = int.Parse(Console.ReadLine());
                        Console.WriteLine($"factorial of number {s} is :" + obj.factorial(s));
                        break;
                    case 3:

                        Console.WriteLine("enter number grater than 1 : ");
                        int b = int.Parse(Console.ReadLine());
                        obj.prime(b);
                        break;
                   
                    
                    default:
                        Console.WriteLine("invalid input ");
                        break;

                }
                Console.WriteLine("do you wish to continue");
                Console.WriteLine("press y continue");
                Console.WriteLine("press n to exit");
                string num1 = Console.ReadLine();
                if (num1 == "y")
                {
                    Main();
                }
                else
                {
                    break;
                }




            } 

        }
            
        }
    }

