using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_5
{
    internal class Program
    {
        static double f(double x)
        {
             //если х не попадает в область определения, то генерируется исключение 
                if ((x*x+2*x+1)==0  || (x * x + 2 * x + 1)<0) throw new Exception(); //оператор throw создает исключение 
                else return ((3*x+4)/(Math.Sqrt(x*x+2*x+1)));
            
        }

        static void Main(string[] args)
        {
            double a;
            double b;
         
            try
            {
                Console.Write("a=");
                 a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                 b = double.Parse(Console.ReadLine());
                        Console.Write("h=");
                       double  h = double.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("'a' не может быть больше'b'");
                }
                else if (h <= 0)
                {
                    Console.WriteLine("Шаг должен быть больше 0");
                }
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=функция не определена", i);
                    }

            }
            //Проверка на ввод 
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные");
            }

            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }


        }


    }


}

