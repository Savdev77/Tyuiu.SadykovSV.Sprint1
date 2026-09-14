using Tyuiu.SadykovSV.Sprint1.Task5.V2.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                        *");
Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("* Введите значение температуры в градусах Фаренгейта:                     *");
double f = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(f+ "° по Фаренгейту равно " + ds.FahrenheitToСelsius(f)+ "° по Цельсию.");

Console.ReadKey();