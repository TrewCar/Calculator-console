using System;

namespace calc
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("В этой версии всё доступно, но доступны только уровнения без скобок.");
            Console.WriteLine("    ");
            Console.WriteLine("Введите кол-во чисел и символов (минимум 3, и только нечётные числа)");

            Console.ForegroundColor = ConsoleColor.White;
            int i = Convert.ToInt32(Console.ReadLine()); //Ввод кол-во

            i += 2;   //Ввод доп. элементов для массива
             
            string[] array = new string[i];     //Введение основного массива
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Вводите числа и символы через Enter");     
            Console.ForegroundColor = ConsoleColor.White;

            for (int g = 0; g < i-2; g++) 
            {               
                array[g] = Console.ReadLine();  //Задан массив всех чисел и смволов               
            }

            string[] array2 = new string[i];    

            for (int g = 2; g < i; g++) 
            {
                array2 [g] = array[g];                 //Задан доп. массив всех чисел и смволов    
            }

            
            array[ i - 2 ] = "+";    // +0 доп. элементы массива для правильного функционирования
            array[ i - 1 ] = "0";

            Console.WriteLine("    ");
            Console.WriteLine("    ");

            double result = 0;     //Ввод переменных для правильного функционирования
            double PlusMinus = 0;
            double resDelUmn = 0;
            

                    //Ввод переменных для удобства
            


            

            for (int g = 1; g<i; g++) // как мы знаем первым делается * или /, так что ищем их
            {
                if (array[g] == "*")  //поиск *
                {
                    double a = Convert.ToDouble(array[g - 1]);     //Вытаскивание числе возле знака
                    double b = Convert.ToDouble(array[g + 1]);

                    resDelUmn = a * b;
                    if (g - 2 < 0)
                    {
                        goto endEmn;
                    }
                    if (array[g-2] == "-")       // идт проверка, есть ли - перед первой переменной
                    {
                        resDelUmn = resDelUmn * -1;               
                    }
                    if (array[g - 2] == "+")       // идт проверка, есть ли + перед первой переменной
                    {
                        resDelUmn = a * b;
                    }

                    endEmn:
                    array[g + 1] = Convert.ToString(resDelUmn);       //Запись результата в правое число
                    

                    array[g - 1] = Convert.ToString(0);       // Запись 0 в левое число
                    
                }

                if (array[g] == "/")     //поиск /
                {
                    double a = Convert.ToDouble(array[g - 1]);
                    double b = Convert.ToDouble(array[g + 1]);

                    resDelUmn = a / b;
                    if (g-2<0)
                    {
                        goto endEmn;
                    }
                    if (array[g - 2] == "-")
                    {
                        resDelUmn = resDelUmn * -1;
                        
                    }
                    if (array[g - 2] == "+")       // идт проверка, есть ли + перед первой переменной
                    {
                        resDelUmn = a / b;
                    }

                    endEmn:
                    array[g + 1] = Convert.ToString(resDelUmn);
                    

                    array[g - 1] = Convert.ToString(0);
                    
                }
            }
            
            for (int g = 1; g<i; g++)     //Поиск - и + 
            {

                if (array[g] == "-")   // Поиск - и его действие
                {
                    double a = Convert.ToDouble(array[g - 1]);
                    double b = Convert.ToDouble(array[g + 1]);
                    if (g == i - 1)
                    {                        
                        result = a + b;
                        goto endPlus;
                    }
                    if (array[g + 1] != array[g + 1])
                    {
                        result -= a;
                        goto endPlus;
                    }
                    if (g-2<0 || array[g-2] == "*" || array[g - 2] == "/")
                    {
                        result = a - b;
                        goto endPlus;
                    }
                    if (g-2>0 && array[g - 2] != "*" || array[g - 2] == "/")
                    {
                        result -= b;
                        goto endPlus;
                    }
                    
                    
                }

                if (array[g] == "+")   // Поиск + и его действие
                {

                    double a = Convert.ToDouble(array[g - 1]);
                    double b = Convert.ToDouble(array[g + 1]);  //Вытаскивание значений возле знака
                    
                    if(g==i-1)
                    {

                        result = a + b;
                        goto endPlus;
                    }
                    if (array[g+1] != array[g + 1])
                    {
                        result += a;
                        goto endPlus;
                    }
                    if (g - 2 < 0 || array[g - 2] == "*" || array[g - 2] == "/")
                    {
                        result = a + b;
                        goto endPlus;
                    }
                    if (g - 2 > 0 && array[g - 2] != "*" || array[g - 2] == "/")
                    {
                        result += b;
                        goto endPlus;
                    }
                }

                endPlus:
                PlusMinus += result;
                
                
                result = 0;
                
            }

            

            Console.WriteLine("Равно: "+ PlusMinus);//Вывод результата
            
            //Console.WriteLine("    ");
            //Console.WriteLine("    ");
            //for (int g = 0; g < i; g++)          //Проверка массива на ошибки
            //{
                //Console.WriteLine(array[g]);
            //}
            

        }
    }
}
