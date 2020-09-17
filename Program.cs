using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번쨰 숫자 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두번쨰 숫자 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("연산자(+,-*,/)");
            string aa = Console.ReadLine();

            switch (aa)
            {
                case "+":
                    Console.Write(num1 + num2);
                    break;
                case "-":
                    Console.Write(num1 - num2);
                    break;
                case "*":
                    Console.Write(num1 * num2);
                    break;
                case "/":
                    Console.Write(num1 / num2);
                    break;

            }
        }
    }
}
