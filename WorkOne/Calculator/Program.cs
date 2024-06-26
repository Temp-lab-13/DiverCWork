﻿namespace Calculator
{
    internal class Program
    {
        /*
            Задача:
                Написать программу-калькулятор, вычисляющую выражения вида:
                a + b, a - b, a / b, a* b
                Введенные из командной строки, и выводящую результат выполнения на экран.

            Пример вызова программы:
                program.exe 10 + 20

            Пример вывода результата:
                10 + 20 = 30
                В результате операции сложения чисел 10 и 20 получился ответ 30.
        */
 
        static void Main(string[] args)
        {
            Calc(args);
        }

        // Всё будет происходить в отдельном методе, вызываемом через main.
        static void Calc(string[] args)
        {
            // Первичная провекра на коректность длины массива. Должно быть ровно 3 элемента.
            if (args.Length == 3) {
                //Проверка и парсинг в числа первого и посчледнего элемента массива, которые должны быть числами. 
                if (int.TryParse(args[0], out var numOne) && int.TryParse(args[2], out var numTwo))
                {
                    int resalt = 0;  //хранитель резельтата.
                    int err = 0; // Флажок ошибки.
                    // Поиск среди доступных для обработки оператора переданного пользователем значения.
                    if (args[1] == "+")
                    {
                        resalt = numOne + numTwo;
                    } else if (args[1] == "-")
                    {
                        resalt = numOne - numTwo;
                    } else if (args[1] == "*")
                    {
                        resalt = numOne * numTwo;
                    } else if (args[1] == "/" && numOne != 0 && numTwo != 0)
                    {
                        resalt = numOne / numTwo;
                    } else
                    {
                        // Если переданный оператор не поддерживается программой (или не корректны),
                        // Пишем об ошибке и поднимаем Флажок.
                        err = 1;
                        Console.WriteLine("Введён не корректный оператор. Доступные операторы вычисления: `+`, `-`, `/`, `*`;");
                    }
                    // Проверка Флажка. Если он поднят, то результат не выводим.
                    if (err != 1)
                    {
                        Console.WriteLine($"{numOne} {args[1]} {numTwo} = {resalt}");
                    }
                    
                }
                // Если значения не числа, то пишем об ошибке.
                else
                {
                    Console.WriteLine("Введеные данные не являются числами.");
                }
                  
            }
            // Если данные переданны не корректно, пишем об ошибке.
            else
            {
                Console.WriteLine("Введенные данные не корректны. Формат ввода: 'number' '+-/*' 'number'");
            }
        }
    }
}