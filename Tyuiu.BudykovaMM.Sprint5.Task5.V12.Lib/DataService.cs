using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BudykovaMM.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double sum1 = 0;
            double sum2 = 0;

            string allText = File.ReadAllText(path);

            string[] numbers = allText.Split(' ');

            foreach (string value in numbers)
            {
                string formattedNum = value.Replace('.', ',');

                double numb = Convert.ToDouble(formattedNum);

                if (numb == Math.Truncate(numb))
                {
                    if (numb > 0)
                    {
                        sum1 += numb;
                    }
                    if (numb < 0)
                    {
                        sum2 += numb;
                    }
                }
            }
            return Math.Round(sum1-sum2, 3);
        }
    }
}
