using Tyuiu.SadykovSV.Sprint1.Task2.V8.Lib;
DataService ds= new DataService();
Console.Title = "Спринт #1 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в С#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");
int a, b;

Console.WriteLine("Введите длину первой стороны прямоугольника: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны прямоугольника: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Периметр прямоугольника равен: " + ds.CalculatePerimetr(a, b));
Console.ReadKey();