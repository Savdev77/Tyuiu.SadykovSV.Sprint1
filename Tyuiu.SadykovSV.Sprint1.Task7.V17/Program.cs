using Tyuiu.SadykovSV.Sprint1.Task7.V17.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("* (1 + sin(sqrt(x^2 + 1))) / cos(12*y - 4)                                *");
Console.WriteLine("***************************************************************************");

double x, y;

Console.WriteLine("* Введите значение x:                                                     *");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("* Введите значение y:                                                     *");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double result = ds.Calculate(x, y);
Console.WriteLine($" Результат вычисления выражения: {result} ");

Console.ReadKey();
