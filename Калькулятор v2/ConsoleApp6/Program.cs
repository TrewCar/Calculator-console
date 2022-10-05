using ConsoleApp6;
using System;
using System.Runtime.InteropServices;

class program2
{

        
    static void Main(string[] args)
    {
            
        Console.Title = "Калькулятор";

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("В этой версии доступно всё. Кроме уровнений со скобками");
        Console.WriteLine("Доступные символы: + , - , / , * , cos , sin , tg , ctg , ^");
        Console.WriteLine("    ");
        Console.WriteLine("Введите кол-во чисел и символов (примеры в README)");

        Console.ForegroundColor = ConsoleColor.White;
        int i = Convert.ToInt32(Console.ReadLine()); //Ввод кол-во

        i += 4;   //Ввод доп. элементов для массива

        string[] array = new string[i];     //Введение основного массива
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Вводите числа и символы через Enter");
        Console.ForegroundColor = ConsoleColor.White;

        for (int g = 2; g < i-2; g++)
        {
            array[g] = Console.ReadLine();  //Задан массив всех чисел и смволов               
        }
        
        array[0] = "0";
        array[1] = "+";
        array[i-1] = "0";
        array[i-2] = "+";


        Console.WriteLine("    ");
        Console.WriteLine("    ");



        ArrayTools tools = new ArrayTools();

        tools.CosSin(array);
        string[] arra = array.EachDistinct().ToArray();


        DelUmn tool = new DelUmn();

        
        tool.delumn(arra);

        string[] arra2 = arra.EachDistinct().ToArray();


        

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
