using System.IO;
using Tyuiu.BudykovaMM.Sprint5.Task6.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка текстовых файлов.                                       *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string file = "InPutDataFileTask6V24.txt";
        string directory = @"C:\\DataSprint5";
        string path = Path.Combine(directory, file);

        Console.WriteLine("Данные находятся в файле: " + path);


        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        double res = ds.LoadFromDataFile(path);


        Console.WriteLine("Количество пятизначных чисел в файле = " + res);


        Console.ReadKey();
    }
}