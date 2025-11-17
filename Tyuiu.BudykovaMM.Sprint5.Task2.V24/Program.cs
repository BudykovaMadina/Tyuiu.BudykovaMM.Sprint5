using Tyuiu.BudykovaMM.Sprint5.Task2.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { 6, 0, 6 },
                                      {-1, -8, 7 },
                                      { 5, 1, 0 } };

        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        DataService ds = new DataService();

        Console.Title = "Спринт #5 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл.     *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}