using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Calc
{
    public class Calculator
    {
        static int Main()
        {
            double FirstNumber = 0.0;
            double SecondNumber = 0.0;
            bool end = false;


            try
            { while (!end)
                {
                    Program object1 = new Program();
                    Console.WriteLine(" Enter first number: ");
                    FirstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Enter second number: ");
                    SecondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n 5 - Exit");
                    Console.Write(" Enter the transaction code: ");
                    int transactioncode = Convert.ToInt32(System.Console.ReadLine());
                    switch (transactioncode)
                    {
                        case 1:
                            Console.Write(" The result of addition: " + object1.Addition(FirstNumber, SecondNumber) + '\n');
                            break;

                        case 2:
                            Console.Write(" The result of subtraction: " + object1.Subtraction(FirstNumber, SecondNumber) + '\n');
                            break;
                        case 3:
                            Console.Write(" The result of multiplication: " + object1.Multiplication(FirstNumber, SecondNumber) + '\n');
                            break;

                        case 4:
                            Console.Write(" The result of division: " + object1.Division(FirstNumber, SecondNumber) + '\n');
                            break;
                        case 5:
                            end = true;
                            break;
                    }




                }
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

            return 0;

            }
        }
    }
