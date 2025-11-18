using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BudykovaMM.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string file = "OutPutDataFileTask7V4.txt";
            string directory = Path.GetTempPath();
            string pathSave = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;


            if (fileExists)
            {
                File.Delete(pathSave);
            }

            StringBuilder sb = new StringBuilder();

            Regex rus = new Regex("[А-Яа-яЁё]");

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string converted = rus.Replace(line, "#");
                    sb.AppendLine(converted);
                }
            }

            File.WriteAllText(pathSave, sb.ToString());

            return pathSave;

        }
    }
}
