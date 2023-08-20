using System;
using System.Collections;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization; /* Пространство имен */
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // СЛОЖЕНИЕ ЧИСЕЛ В КОНСОЛИ УРОК 5
            /*
            String str;

            int a, b;

            Console.WriteLine("Введите число 1");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int summa = a + b;

            Console.WriteLine("Результат");

            Console.WriteLine(summa);

            */


            // МЕТОД CONVERT УРОК 6
            /*
            String str = "5,5";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()        // Создали ЭКЗЕМПЛЯР new, КЛАССА NumberFormatInfo 

            {
                NumberDecimalSeparator = ".",                                 // Создали ПОЛЕ NumberDecimalSeparator, который носит строковую характеристику String
            };

            Double a = Convert.ToDouble(str, numberFormatInfo);

            */


            // МЕТОД PARSE УРОК 7 
            /*
            
            String str = "5.5dfgdfg";                               // Задаем произвольную строку 

            try                                                     // Прописываем БЛОК try catch 
            {
                int a = int.Parse(str);                             // Метод Parse Работает по принципу метода Convert
                Console.WriteLine("Число записано");
            }
            catch (Exception)                                       // Exception - Некорректный формат 
            {
                Console.WriteLine("Некорректное число");
            }
            */


            // МЕТОД TRYPARSE УРОК 7
            /* 
             string str = "ngjkh5";                                  

             int a;

             bool result = int.TryParse(str, out a);                     // При помощи МЕТОДА TryParse и МОДИФИКАТОРА Out, делаем конвертацию переменной типа string в переменную типа int,
                                                                         // Сначала МЕТОД Инициализирует число на ТИП ДАННЫХ string, далее Преобразует его в ТИП ДАННЫХ Int, и Возвращает конвертированное число,
                                                                         // в Тип данных int и дополнительно на выходе получаем значение True или False, в зависимости от результата.

             if (result)                                                 // Вилка If Else. Как работает: Пишем If, а рядом в скобочках пишем условие для истины.
             {
                 Console.WriteLine("Число конвертировано " + a);
             }

             else                                                        // Тут писать ничего не нужно, тут автоматически условие для значения Ложь   
             {
                 Console.WriteLine("Число некорректно");
             }
             */


            // ОПЕРАТОРЫ АРИФМЕТИЧЕСКИЕ ЧИСЛА УРОК 8 
            /*
             int a = 6;
             int b = 2;

             int result = a % b;
             Console.WriteLine(result);
             */


            //ДЗ 
            // 1) НАПИШИТЕ ПРОГРАММУ ВЫЧИСЛЯЮЩУЮ СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ ДВУХ ЧИСЕЛ
            /*            
            int a, b;

            string str;

            int result;

            Console.WriteLine("Введите первое число");

            str = Console.ReadLine();

            a = int.Parse(str);

            Console.WriteLine("Введите второе число");

            str = Console.ReadLine();

            b = int.Parse(str);

            result = (a + b) / 2;

            Console.WriteLine("Среднее арифметическое двух чисел " + result);
            */

            // 2)  ВВЕДИТЕ ТРИ ЧИСЛА И ВЫВЕДИТЕ НА ЭКРАН ЗНАЧЕНИЕ СУММЫ И ПРОИЗВЕДЕНИЯ ЭТИХ ЧИСЕЛ
            /*
            int a, b, c;

            int summ, proizvedenie;

            string str;

            Console.WriteLine("Введите первое число");

            str = Console.ReadLine();

            a = int.Parse(str);

            Console.WriteLine("Введите второе число");

            str = Console.ReadLine();

            b = int.Parse(str);

            Console.WriteLine("Введите третье число");

            str = Console.ReadLine();

            c = int.Parse(str);

            summ = a + b + c;

            Console.WriteLine("Сумма трех чисел " + summ);

            proizvedenie = a * b * c;

            Console.WriteLine("Произведение трех чисел " + proizvedenie);
            */

            // 3) КОНВЕРТЕР ВАЛЮТ 
            /*
            Double Rub, Dol;

            String str;

            int vibor;

            Console.WriteLine("КУРС ВАЛЮТЫ: 1 ДОЛЛАР = 60 Рублей. Если конвертировать рубль - доллар напишите 1, если доллар - рубль напишите 2");

            str = Console.ReadLine();

            vibor = int.Parse(str);

            if (vibor == 1)

            {
                Console.WriteLine("Введите Рубли");

                str = Console.ReadLine();

                Rub = Convert.ToDouble(str);

                Dol = Rub / 60;

                Console.WriteLine("КУРС ОБМЕНА " + Dol);
            }

            else

            {
                Console.WriteLine("Введите доллары");

                str = Console.ReadLine();

                Dol = Convert.ToDouble(str);

                Rub = Dol * 60;

                Console.WriteLine("КУРС ОБМЕНА " + Rub);
            }
            */


            // Инкремент Декремент, Постфиксный и Префиксный УРОК 11
            /*
            int a = 2;
            
            a = ++a * a;                      // Так как инкремент префиксный, он имеет наивысший приоритет, Поэтому сначала все переменные в строке увеличатся
                                          // на 1, а затем произойдет умножение: а = (1 + 1) * (1 + 1) = 4
            Console.WriteLine(a);
            */


            // ОПЕРАЦИИ СРАВНЕНИЯ | ОПЕРАТОРЫ ОТНОШЕНИЯ УРОК 12
            /*
            == Равно
            != Не равно
            > Больше
            < Меньше
            >= Больше или равно
            <= Меньше или равно

            int a = 5;

            int b = 5;

            Console.WriteLine(a == b);

            Console.WriteLine(b != a);

            Console.WriteLine(a <= b);

            Console.WriteLine(a >= b);

            Console.WriteLine(b > a);

            Console.WriteLine(a < b);
            */


            // IF ELSE КОНСТРУКЦИЯ ЛОГИЧЕСКОГО ВЫБОРА УРОК 13
            /*
            int a = int.Parse(Console.ReadLine());

            int b = a % 2;

            if (b > 0)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }
            */

            // ЛОГИЧЕСКИЕ ОПЕРАТОРЫ УРОК 14
            /*
            int fanspeed = -5;

            bool Hightemperature = true;

            bool HasNotCooling = fanspeed<=0;

            if (Hightemperature || HasNotCooling) 
            {
                Console.WriteLine("Опасность перегрева");
            }
            */

            //ОПЕРАТОР МНОЖЕСТВЕННОГО ВЫБОРА SWITCH УРОК 15
            /*
            string a = Console.ReadLine();
            switch (a)
            {
                case "+": 
                Console.WriteLine("Выбрана операция сложения");           
                break;
                case "-":
                Console.WriteLine("Выбрана операция вычитания");
                break;
                default:
                Console.WriteLine("Введено некорректное значение");
                break;
            }
            
            ConsoleKey consoleKey = Console.ReadKey().Key;      // ConsoleKey Это Тип данных Enum, о котором мы поговорим позже. consoleKey - Это название переменной
                                                                // Console.ReadKey() - Это метод, который позволяет считывать любую нажатую клавишу Key - Это ПОЛЕ.
            switch (consoleKey)
            {
                case ConsoleKey.Backspace:
                    Console.WriteLine("nAJAL BACKSPEIS");
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.LeftWindows:
                    break;
                case ConsoleKey.RightWindows:
                    break;
                case ConsoleKey.Applications:
                    break;
                case ConsoleKey.Sleep:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                case ConsoleKey.Multiply:
                    break;
                case ConsoleKey.Add:
                    break;
                case ConsoleKey.Separator:
                    break;
                case ConsoleKey.Subtract:
                    break;
                case ConsoleKey.Decimal:
                    break;
                case ConsoleKey.Divide:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.F10:
                    break;
                case ConsoleKey.F11:
                    break;
                case ConsoleKey.F12:
                    break;
                case ConsoleKey.F13:
                    break;
                case ConsoleKey.F14:
                    break;
                case ConsoleKey.F15:
                    break;
                case ConsoleKey.F16:
                    break;
                case ConsoleKey.F17:
                    break;
                case ConsoleKey.F18:
                    break;
                case ConsoleKey.F19:
                    break;
                case ConsoleKey.F20:
                    break;
                case ConsoleKey.F21:
                    break;
                case ConsoleKey.F22:
                    break;
                case ConsoleKey.F23:
                    break;
                case ConsoleKey.F24:
                    break;
                case ConsoleKey.BrowserBack:
                    break;
                case ConsoleKey.BrowserForward:
                    break;
                case ConsoleKey.BrowserRefresh:
                    break;
                case ConsoleKey.BrowserStop:
                    break;
                case ConsoleKey.BrowserSearch:
                    break;
                case ConsoleKey.BrowserFavorites:
                    break;
                case ConsoleKey.BrowserHome:
                    break;
                case ConsoleKey.VolumeMute:
                    break;
                case ConsoleKey.VolumeDown:
                    break;
                case ConsoleKey.VolumeUp:
                    break;
                case ConsoleKey.MediaNext:
                    break;
                case ConsoleKey.MediaPrevious:
                    break;
                case ConsoleKey.MediaStop:
                    break;
                case ConsoleKey.MediaPlay:
                    break;
                case ConsoleKey.LaunchMail:
                    break;
                case ConsoleKey.LaunchMediaSelect:
                    break;
                case ConsoleKey.LaunchApp1:
                    break;
                case ConsoleKey.LaunchApp2:
                    break;
                case ConsoleKey.Oem1:
                    break;
                case ConsoleKey.OemPlus:
                    break;
                case ConsoleKey.OemComma:
                    break;
                case ConsoleKey.OemMinus:
                    break;
                case ConsoleKey.OemPeriod:
                    break;
                case ConsoleKey.Oem2:
                    break;
                case ConsoleKey.Oem3:
                    break;
                case ConsoleKey.Oem4:
                    break;
                case ConsoleKey.Oem5:
                    break;
                case ConsoleKey.Oem6:
                    break;
                case ConsoleKey.Oem7:
                    break;
                case ConsoleKey.Oem8:
                    break;
                case ConsoleKey.Oem102:
                    break;
                case ConsoleKey.Process:
                    break;
                case ConsoleKey.Packet:
                    break;
                case ConsoleKey.Attention:
                    break;
                case ConsoleKey.CrSel:
                    break;
                case ConsoleKey.ExSel:
                    break;
                case ConsoleKey.EraseEndOfFile:
                    break;
                case ConsoleKey.Play:
                    break;
                case ConsoleKey.Zoom:
                    break;
                case ConsoleKey.NoName:
                    break;
                case ConsoleKey.Pa1:
                    break;
                case ConsoleKey.OemClear:
                    break;
                default:
                    break;
            }
            */

            // ДЗ ПИШЕМ КАЛЬКУЛЯТОР НА ОПЕРАТОРЕ SWITCH CASE
            /*
            Console.WriteLine("Введите первое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберете операцию +, -, * или /");
            string c = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());
            double d;
            switch (c)
            {
                case "+":
                d = a + b;
                Console.WriteLine("Результат сложения двух чисел " + d);
                break;
                case "-":
                d = a - b;
                Console.WriteLine("Результат вычитания двух чисел " + d);
                break;
                case "*":
                d = a * b;
                Console.WriteLine("Результат умножения двух чисел " + d);
                break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно");
                    }
                    else
                    {
                        d = a / b;
                        Console.WriteLine("Результат деления двух чисел " + d);
                    }             
                break;
                default:
                Console.WriteLine("Некорректная операция");
                break;
            }
            */


            //ЦИКЛ WHILE УРОК 16
            /*
            int Count = 0;
            while (Count < 5)
            {
                Count = Count++;
                Console.WriteLine("Count= " + Count);
            }
            */

            //Калькулятор на while
            /* 
             int PervoeZnach;
             int VtoroeZnach;
             int Znak;
             int Rezult = 0;
             string str;

             Console.WriteLine("Введите первое число");
             PervoeZnach = int.Parse(Console.ReadLine());
             Console.WriteLine("Выберете операцию 1:+, 2:-, 3:* или 4:/");
             str = Console.ReadLine();
             Znak = int.Parse(str);
             while (Znak!=5)

             {             
              Console.WriteLine("Введите второе число");
              VtoroeZnach = int.Parse(Console.ReadLine());
                 switch (Znak)
                 {
                     case 1:
                     Rezult = PervoeZnach + VtoroeZnach;
                     Console.WriteLine("Результат сложения двух чисел " + Rezult);
                     break;
                     case 2:
                     Rezult = PervoeZnach - VtoroeZnach;
                     Console.WriteLine("Результат вычитания двух чисел " + Rezult);
                     break;
                     case 3:
                     Rezult = PervoeZnach * VtoroeZnach;
                     Console.WriteLine("Результат умножения двух чисел " + Rezult);
                     break;
                     case 4:
                     Console.WriteLine("Результат деления двух чисел " + Rezult);
                         if (VtoroeZnach == 0)
                         {
                             Console.WriteLine("Деление на ноль невозможно");
                         }
                         else
                         {
                             Rezult = PervoeZnach / VtoroeZnach;
                             Console.WriteLine("Результат деления двух чисел " + Rezult);
                         }
                         break;
                 }
              PervoeZnach = Rezult;
              Console.WriteLine("Выберете операцию 1:+, 2:-, 3:*, 4:/ или 5:=");
              str = Console.ReadLine();
              Znak = int.Parse(str);
             }

             Console.WriteLine("Ответ " + Rezult);
             str = Console.ReadLine();
             */

            //ЦИКЛ DO WHILE УРОК 17
            /*
            int Count = 0;
            do
            {
                Count++;
                Console.WriteLine(Count);
            } while (Count<5);
            */
            //ДЗ 4
            // Сделать калькулятор, который считает сумму четных и нечетных чисел, в заданном диапазоне.
            /*
             int NachaloDiapazona;
             int KonecDiapazona;
             NachaloDiapazona = Convert.ToInt32(Console.ReadLine());
             KonecDiapazona = Convert.ToInt32(Console.ReadLine());
             int SummChetnih = 0;
             int SummNechetnih = 0;
             while (NachaloDiapazona <= KonecDiapazona)
                 {
                 int Ostatok = NachaloDiapazona % 2;
                 if (Ostatok > 0)
                     {
                    SummNechetnih = SummNechetnih + NachaloDiapazona;
                     }
                 else 
                     {
                    SummChetnih = SummChetnih + NachaloDiapazona;
                     }
                 NachaloDiapazona++;
                 }
             Console.WriteLine("сумма нечетных " + SummNechetnih);             // =8
             Console.WriteLine("сумма четных " + SummChetnih);                 // =6
            */

            // Цикл for УРОК 18
            /*
            int length = 10;

            for (int i = 0; i < length; i++)
                {

                    Console.WriteLine(i);
                }
            */

            // Цикл for В ОБРАТНОМ ПОРЯДКЕ | НЕСКОЛЬКО ПЕРЕМЕННЫХ | НЕСКОЛЬКО УСЛОВИЙ УРОК 19
            /*
            int i = 0;                  //i работает для обоих циклов
            
            for (; i < 3; i++)          // УБРАЛИ ПЕРВОЕ УСЛОВИЕ! 
            {
                Console.WriteLine("for 1 " + i);
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("for 2 " + i);
            }
            
            for (; i < 5; )             // убираем последнее условие и получаем бесконечный цикл
            {
                Console.WriteLine(i);
            }
            
            for (int i = 0, j = 5; i < 5 && j < 12; i++, j++)        // Добавили новую переменную!
            {
                Console.WriteLine("i= " + i);
                Console.WriteLine("j= " + j);
            }

            for (int i = 5; i >= 0; i--)    // Сделали цикл на убывание
            {
                Console.WriteLine(i);
            }
            
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)        // Записываем i сразу 
            {
                Console.WriteLine(i);
            }
            */

            //Оператор Break УРОК 20 
            /* 
             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine(i);
                 string msg = Console.ReadLine();
                 if (msg == "Stop")
                 {
                     break;
                 }
             }
             */

            //Оператор Continue УРОК 21
            /*
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/


            //ВЛОЖЕННЫЕ ЦИКЛЫ УРОК 22
            /*
             //Пример вложенных циклов
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Итерация для i " + i);
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("\tИтерация для j " + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tИтерация для k " + k);
                    }
                }
            }
            
            // Рисуем рямоугольник, при помощи вложенных циклов:
            
            Console.WriteLine("Задайте высоту прямоугольника");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте ширину прямоугольника");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            */
            // Рисуем треугольник, при помощи вложенных циклов УРОК #22
            // ДЗ Треугольник на увеличение 
            /*
            Console.WriteLine("Задайте высоту треугольника");
            int VisotaTreyg = int.Parse(Console.ReadLine());
                        
            int a = 0;
            for (int i = 0; i < VisotaTreyg; i++)
            {   
                a++;
                for (int j = 0; j < a; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            */
            // ДЗ Треугольник на уменьшение УРОК #22
            /*
                        Console.WriteLine("Задайте высоту треугольника");
                        int VisotaTreyg = int.Parse(Console.ReadLine());

                        for (int i = 0; i < VisotaTreyg; )
                        {                
                            for (int j = 0; j < VisotaTreyg; j++)
                            {
                                Console.Write("#");
                            }
                            VisotaTreyg--;
                            Console.WriteLine();
                        }
            */

            // ДЗ Треугольник на уменьшение с противоположной стороны УРОК #22
            /*
            Console.WriteLine("Задайте высоту треугольника");
            int VisotaTreyg = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < VisotaTreyg;)
            {
                
                for (int j = 0; j < VisotaTreyg; j++)
                {
                    Console.Write(" ");
                }
                
                a++;

                for (int k = 0; k < a; k++)
                {
                    Console.Write("#");
                }

                VisotaTreyg--;
                Console.WriteLine();
            }
            */
            // ДЗ Треугольник на увеличение с противоположной стороны УРОК #22
            /*
            Console.WriteLine("Задайте высоту треугольника");
            int VisotaTreyg = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < VisotaTreyg;)
            {
                
                for (int k = 0; k < a; k++)
                {
                    Console.Write(" ");
                }

                a++;

                for (int j = 0; j < VisotaTreyg; j++)
                {
                    Console.Write("#");
                }

                VisotaTreyg--;
                Console.WriteLine();
            }
            */

            //ТЕРНАРНЫЙ ОПЕРАТОР УРОК #23
            /*
            bool result;
            string str1 = "qwerty";
            string str2 = Console.ReadLine();

            
            if (str1 == str2) 
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);
            Console.ReadLine();
            */
            /*
            result = str1 == str2 ? true : false ;
            Console.WriteLine(result);
            Console.ReadLine();
            */
            /*
            int InputData = int.Parse(Console.ReadLine());
            int OutputData = (InputData < 0) ? 0 : InputData;
            Console.WriteLine(OutputData);
            */

            //ЧТО ТАКОЕ МАССИВЫ | ОДНОМЕРНЫЙ МАССИВ. УРОК #24
            /*
            int[] MyArray;                    //Обьявляем массив

            MyArray = new int[5];            // Выделяем место в Оперативной памяти под массив

            MyArray[1] = 3;                   // записываем значение 3, в элемент под индексом 1

            MyArray[0] = 10;                   // записываем значение 10, в элемент под индексом 0

            int a = MyArray[0];                // Извлекаем данные из массива в отдельную переменую, а вернее извлекаем элемент под индексом 0, в перменную а

            Console.WriteLine(a);
            */
            /* 
             int[] MyArray;

             MyArray = new int[112312];

             Console.WriteLine(MyArray.Length);
             */

            //ИНИЦИАЛИЗАЦИЯ МАССИВА. УРОК #25
            /*
            Int[] MyArray = new int[5] { 1, 2, 6, 12, 56 };     //  Мы можем инициализировать все ячейки массива в фигурных скобках.
                                                                //  НО мы должны инициализировать все ячейки массива, инчае будет ошибка.

            Int[] MyArray = new int[] { 2, 6, 12, 56 };          // В данном случае мы не указываем количество ячеек в массиве,
                                                                 // поэтому массив будет автоматически создан на 4 ячейки.

            Int[] MyArray = new[] { 2, 6, 12, 56 };                // В данном случае мы не указываем тип данных int, так тоже можно,
                                                                   // если казать в фигурных скобках все элементы массива, если не указать в фигурных скобках все элементы,
                                                                   // то такой способ не пройдет.

            Int[] MyArray = new int[4];                                 // Можем указать только кол-во ячеек в массиве, НО с указанием типа данных.

            Int[] MyArray = { 2, 6, 12, 56 };                             // Можем вообще указать только все данные в фигурных скобках.

            int[] MyArray = Enumerable.Repeat(5, 10).ToArray          // Используя класс Enumerable и метод Repeat, можем выбрать размер массива и
                                                                      // выбрать причисляемое значение для массива.

            int[] MyArray = Enumerable.Range(4, 10).ToArray        // Метод Range позволяет опеределить размер массива и заполняет массив от укзанного числа до конца,
                                                                   // прибавляя елиницу.
            */

            //ВЫВОД МАССИВА. УРОК #26
            /*
            int[] MyArray = { 30, 2, 3 };

            Console.WriteLine(MyArray[0]);               // Вывод элемента массива на консоль

            Console.ReadLine();
            */
            /*
            int[] MyArray = { 30, 2, 3, 2 };

            for (int i = 0; i < MyArray.Length; i++)      // Цикл, который перебирает весь массив
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.ReadLine();
            */

            // ДЗ #5
            // 1) ЗАПОЛНИТЬ МАССИВ С КЛАВИАТУРЫ
            /*
            int[] MyArray = new int[5];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            */
            // 2) Вывести массив в обратном порядке
            /*
                        int[] MyArray = { 30, 2, 3, 2, 5 };

                        int k = 5;

                        for (int i = 0; i < MyArray.Length; i++)
                        {
                            k--;

                            Console.WriteLine(MyArray[k]);
                        }
            */
            // 3) Найти сумму четных чисел в массиве
            /*
            int[] MyArray = new int[] { 1, 2, 3, 4 };

            int Summ = 0;

            for (int i = 0; i < MyArray.Length; i++)
            {
                int a = MyArray[i];

                int b = a % 2;

                switch (b) 
                {
                    case 0:
                        Summ = Summ + a;
                        break;
                }
            }
            
            Console.WriteLine("Сумма четных чисел " + Summ);
            */
            // 4) Найти наименьшее число в массиве
            /*
            int[] MyArray = { 4, 2, 3 };
            int a = - 1;
            int k = 0;                                      //переменная числа, с которой будут сравниваться элементы массива
            for (; a != k ; k++)                                   // Инкрементирует счетчик, после каждого раза, как мы сравним весь массив с счетчиком к
            {

                for (int i = 0;  i < MyArray.Length; i++)
                {
                    if (MyArray[i] == k)
                    {
                        a = k;
                        a++;
                        Console.WriteLine(MyArray[i]);
                    }
                }

            }
            */
            // 5) Вывести массив на консоль, чтобы числа выводились от меньшего, к большему
            // 6) Вывести массив на консоль, чтобы числа выводились от большего, к меньшему
            /*
            int[] MyArray = { 4, 2, 3, 324, 345, 348 };

            int k = 350;                                                        // Переменная числа, с которой будут сравниваться элементы массива

            for (; k > -1; k--)                                                       // Инкрементирует счетчик, после каждого раза, как мы сравним весь массив с счетчиком к
            {
                for (int i = MyArray.Length-1; 0 <= i; i--)                      // Перебирает все элементы массива от конца к началу
                {
                    if (MyArray[i] == k)
                    {
                        Console.WriteLine(MyArray[i]);  
                    }
                }
            }
            Console.WriteLine("Программа завершена");
            */

            // КАК РАБОТАТЬ С МАССИВАМИ В C# НА САМОМ ДЕЛЕ. УРОК #27

            /*  int[] MyArray = { 56, 2, 3, 6, 23, 567, 6786, 1231, 456, 456 };
              Console.WriteLine(MyArray.Max());                                  // Выводит на консоль максимальное значение массива
                Console.WriteLine(MyArray.Sum());                                // Выводит на консоль сумму всех элементов массива
                Console.WriteLine(MyArray.Where(i => i % 2 == 0).Sum());*/        // Используем метод расширения Where, который позволяет поместить внутрь себя условие для поиска. 
                                                                                  //Метод Where принимает в качестве параметра - делегат, который позволяет указать условия для поиска. 
                                                                                  //Сейчас мы зашли слишком далеко, и не будем описывать Делегат, а просто впишем параметр в виде лямбда - 
                                                                                  //выражения , которое проверяет число на четность. Когда метод Where, опеределит все четные элементы массива,
                                                                                  //следующим будет метод Sum, который даст команду на сложение всех четных чисел.

            /* Console.WriteLine(MyArray.Where(i => i % 2 == 0).Min());       // Определяем в массиве все нечетные числа, после чего выводим на консоль наименьшее нечетное число

             int[] MyArray2 = { 43, 34, 43, 23, 2, 34 };
            int[] Result = MyArray2.Distinct().ToArray();                  // Метод Distinct опеределяет уникальные числа, то есть неповторяет одних и тех же чисел
             int[] Result1 = MyArray2.OrderBy(i=>i).ToArray();                  // Метод OrderBy, выстраивает заданный массив по элементам от меньшего к большему 
             int[] Result1 = MyArray2.OrderByDescending(i => i).ToArray();      // Метод OrderByDescending, выстраивает заданный массив по элементам от большего к меньшему 
             Array.Sort(MyArray2);                                               // Метод Sort, класса Array, сортирует наш массив MyArray2, от меньшего элемента к большему
              int result = Array.Find(MyArray2, i => i < 30);                    // Метод Find, класса Array, перебирает массив MyArray2, и возвращает удовлетворяющее лямбда выражению элемент,
                                                                                     // в переменную result
             int result = Array.FindLast(MyArray2, i => i < 30);                     // Делает тоже самое что и метод Find, только начинает поиск с конца
              int[] MyArray3 = Array.FindAll(MyArray2, i => i < 30);              // Возвращает все элементы массива, удовлетворяющие условию, в новы массив
              int result = Array.FindIndex(MyArray2, i=>i == 43);                     // Возвращает индекс элемента, который подходит к условию
             int result = Array.FindLastIndex(MyArray2, i => i == 43);                   // Возвращает индекс элемента, который подходит к условию, только перебирает массив с конца
             Array.Reverse(MyArray2);                                                // переставляет элементы массива в обратном порядке
             int[] result = MyArray2.Where(i => i < 30).ToArray();                       // Используем метод Расширения Where и ToArray, из пространства имен Linq,
                                                                                             // для того чтобы вернуть все элементы меньше 30 в массив result
             int result = MyArray2.Where(i => i < 30).First();                // Используем метод Расширения Where и First, из пространства имен Linq, чтобы найти первое наименьшее число
                                                                                  // После выполнения метода Where, информация, удовлетворяющая условию лямбда выражения, будет сохранена в Коллекцию
                                                                                  // Из которой, метод First, возьмет первый элемент
             int result = MyArray2.Where(i=>i<0).FirstOrDefault();                // Метод FirstOrDefault возвращает дефолтное значение, в случае если у нас int он вернет значение 0,
                                                                                  // а в случае если ссылочный тип(Массив), то вернет значение null, короче говоря дефолтное значение данных
                                                                                  // для того типа данных, которое содержится в коллекции. В нашем случае мы получим 0, т.к. у нас int
             Console.ReadLine();*/

            // ДЗ заполните массив с консоли
            /*
            int[] MyArray = new int[10];     
            Random rnd = new Random();                    // Создали генератор случайных чисел
            for (int i = 0; i < MyArray.Length; i++)
            {       
                int value = rnd.Next(0,10);               // Возвращаем случайное число от 0 до 10, в переменную value
                MyArray[i] = value;
            }
            for (int i = 0; i < MyArray.Length; i++)      // Цикл, который перебирает весь массив
            {
                Console.WriteLine(MyArray[i]);
            }
            */

            // Индексы и диапазоны. УРОК 28

            /*int[] MyArray = { 1, 2, 456, 67, 324 };*/
            /*Console.WriteLine(MyArray[MyArray.Length - 1]);*/                                      // вывод на консоль последнего элемента массива
            /*Console.WriteLine(MyArray[^1]);*/                                                      // вывод на консоль последнего элемента массива, С конца нумерация начинается с единицы
            /*int[] MyArray2 = MyArray[1...4];*/                                                      // вытаскиваем из нашего массива в новый массив интересующие нас Элементы               
            /*int[] MyArray2 = MyArray[..5];*/                                                     // Вытаскиваем элементы с 0 го по по5 ый элементы
            /*int[] MyArray2 = MyArray[4..];*/                                                     // Вытаскиваем элементы с 4 го элемента по последний



        }
    }
}




