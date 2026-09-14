using Tyuiu.SadykovSV.Sprint1.Task6.V8.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Садыков С.В. | ПИНБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНБ-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Пользователь вводит текст.                                              *");
Console.WriteLine("* Напечатать все слова, перенеся их первую букву в конец.                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Исходные данные:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("* Введите текст:                                                          *");
string text = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.MoveLetterToEnd(text));

Console.ReadKey();