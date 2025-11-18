using System.IO;
using Tyuiu.BudykovaMM.Sprint5.Task4.V11.Lib;
namespace Tyuiu.BudykovaMM.Sprint5.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string file = "InPutDataFileTask4V11.txt";
            string directory = @"C:\\DataSprint5";
            string path = Path.Combine(directory, file);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
