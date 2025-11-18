using System.IO;
using Tyuiu.BudykovaMM.Sprint5.Task7.V4.Lib;
namespace Tyuiu.BudykovaMM.Sprint5.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string file = "InPutDataFileTask7V4.txt";
            string directory = @"C:\\DataSprint5";
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
