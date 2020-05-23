using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Система счисления");
            int sys = Convert.ToInt32(Console.ReadLine());

            //переводим
            Console.WriteLine("Результат: ");
            Operation(x, sys);
        }

        static void Operation(int number, int system)
        {
            if (system <= 10)
            {
                if (number <= 0) return;
                Operation(number / system, system);
                Console.Write(number % system);
            }
            else
            {
                if (number <= 0) return;
                Operation(number / system, system);
                
                if((number % system) >= 10 && (number % system) <= 15)
                {
                    switch (number % system)
                    {
                        case 10:
                            Console.Write("A");
                            break;

                        case 11:
                            Console.Write("B");
                            break;

                        case 12:
                            Console.Write("C");
                            break;

                        case 13:
                            Console.Write("D");
                            break;

                        case 14:
                            Console.Write("E");
                            break;

                        case 15:
                            Console.Write("F");
                            break;   
                    }    
                }
                else
                {
                    Console.Write(number % system);
                }                
            }
        }
    }
}
