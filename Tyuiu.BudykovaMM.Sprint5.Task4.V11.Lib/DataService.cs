using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BudykovaMM.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            foreach (char symb in strX)
            {

                strX = strX.Replace(".", ",");

            }

            double x = Convert.ToDouble(strX);

            double y = Math.Sin(x) + Math.Pow(x, 2)/2;

            y = Math.Round(y, 3);

            return y;

        }
    }
}
