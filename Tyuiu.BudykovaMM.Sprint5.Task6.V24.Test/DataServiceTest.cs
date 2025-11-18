using System.IO;
using Tyuiu.BudykovaMM.Sprint5.Task6.V24.Lib;
namespace Tyuiu.BudykovaMM.Sprint5.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string file = "InPutDataFileTask6V24.txt";
            string directory = @"C:\\DataSprint5";
            string path = Path.Combine(directory, file);

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string file = "InPutDataFileTask6V24.txt";
            string directory = @"C:\\DataSprint5";
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
