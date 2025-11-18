using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BudykovaMM.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numbers)
                    {
                        if (int.TryParse(numberStr, out int number))
                        {
                            if (number >= 10000 && number <= 99999)
                            {
                                count++;
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}
