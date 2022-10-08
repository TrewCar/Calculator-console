using ConsoleApp6;
using System;
using System.Runtime.InteropServices;

class Program2
{       
    static void Main(string[] args)
    {
        
        X rool = new X();
        Random rand = new Random();
        Console.Title = "Калькулятор";

        Console.ForegroundColor = ConsoleColor.Yellow;
       
        Console.WriteLine("Доступные символы: + , - , / , * , cos , sin , tg , ctg , ^ , log , sqrt, abs, и скобки");
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
        Console.WriteLine("    ");
         
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Введите диапазон x:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("От: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("До: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("    ");
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Введите шаг");
        Console.ForegroundColor = ConsoleColor.White;
        double step = double.Parse(Console.ReadLine());

        err[0] = "0";
        err[1] = "+";
        err[err.Length-1] = "0";
        err[err.Length - 2] = "+";
        string[] err2 = err.ToArray();

        Console.WriteLine("    ");
        Console.WriteLine("    ");

        double fff = rand.NextDouble()* 453.3453346;
        double y = fff;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("x   ||   y");
        Console.ForegroundColor = ConsoleColor.White;
        for (double xx = first; xx <second + step; xx += step)
        {
            
            double yy = rool.sect(err, xx);
            
            
            Console.WriteLine(xx+"   ||   "+yy);

            if(xx == 0)
            {
                y = yy;
            }
            
            for (int g = 0; g < err.Length; g++)
            {
                err[g] = err2[g];
            }
        }       
        if (y == fff)
        {
            y = rool.sect(err, 0);
        }


        Console.WriteLine("    ");
        Console.WriteLine("Точка прикосновения с осью y = "+y);
    }
}
