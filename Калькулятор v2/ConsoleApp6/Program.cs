using ConsoleApp6;
using System;
using System.Runtime.InteropServices;

class Program2
{       
    static void Main(string[] args)
    {
        Skobki skobki = new Skobki();
        ArrayTools tools = new ArrayTools();
        DelUmn tool = new DelUmn();

        Console.Title = "Калькулятор";

        Console.ForegroundColor = ConsoleColor.Yellow;
       
        Console.WriteLine("Доступные символы: + , - , / , * , cos , sin , tg , ctg , ^ , log , sqrt, и скобки");
        Console.WriteLine("Как их использовать написано в README");
        Console.WriteLine("    ");
        Console.WriteLine("Введите числа и символы через пробел");

        Console.ForegroundColor = ConsoleColor.White;
        

        string[] array = Console.ReadLine().Split(new Char[] { ' ' });

        string[] err = new string[array.Length + 4];
        for (int i = 0; i < err.Length; i++)
        {
            if (i < 2 || i > array.Length + 1)
                err[i] = "0";
            else
                err[i] = array[i - 2];
        }

        err[0] = "0";
        err[1] = "+";
        err[err.Length-1] = "0";
        err[err.Length - 2] = "+";


        Console.WriteLine("    ");
        Console.WriteLine("    ");

        
        for (int g = 0; g < err.Length; g++)
        {
            skobki.skobi(err);
        }
        var arra = err.EachDistinct().ToArray();
             
        tools.CosSin(arra);
        string[] arra34 = arra.EachDistinct().ToArray();

       
        tool.delumn(arra34);
        string[] arra2 = arra34.EachDistinct().ToArray();


        

        double result = 0;
        for (int g = 0; g < arra2.Length; g++)
        {
            if (arra2[g] == "+")
            {
                double a = Convert.ToDouble(arra2[g - 1]);
                double b = Convert.ToDouble(arra2[g + 1]);

                if(g-2 < 0)
                {
                    result = a + b;
                }
                else
                {
                    result += b;
                }
            }
            if (arra2[g] == "-")
            {
                double a = Convert.ToDouble(arra2[g - 1]);
                double b = Convert.ToDouble(arra2[g + 1]);

                if (g - 2 < 0)
                {
                    result = a - b;
                }
                else
                {
                    result -= b;
                }
            }
        }

        Console.WriteLine("Равно : " + result);
        
    }
}
