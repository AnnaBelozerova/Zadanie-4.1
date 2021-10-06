using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._1
{
    class Program
    {   //Цикл For: найти квадрат числа 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, квадрат которого хотите найти:");
            uint N = Convert.ToUInt32(Console.ReadLine());
            ulong squareNumber=0;

            for (uint i = 1; i <= (2*N-1); i = i+2)
            {
                squareNumber += i;
                Console.WriteLine(squareNumber);
            }
            Console.WriteLine("Квадрат числа {0} равен {1}", N, squareNumber);
            Console.ReadKey();
        }   
    }
}
