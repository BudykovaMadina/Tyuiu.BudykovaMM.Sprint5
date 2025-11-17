using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BudykovaMM.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string file = "OutPutFileTask1.txt";
            string directory = Path.GetTempPath();
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (double x = startValue; x <= stopValue; x++)
            {
                if ((x - 0.4) != 0)
                {
                    y = Math.Round(Math.Cos(x)/(x-0.4) + Math.Sin(x)*8*x+2, 2);
                    strY = Convert.ToString(y);
                }

                else
                {
                    y = 0;
                    strY = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);

                }

                else
                {
                    File.AppendAllText(path, strY);
                }


            }
            return path;
        }
    }
}
