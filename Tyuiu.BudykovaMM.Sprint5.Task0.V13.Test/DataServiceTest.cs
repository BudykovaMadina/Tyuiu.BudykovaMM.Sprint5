using Tyuiu.BudykovaMM.Sprint5.Task0.V13.Lib;
using System.IO;
namespace Tyuiu.BudykovaMM.Sprint5.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedFileContent()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(5);

            string fileContent = File.ReadAllText(path);
            string wait = "-114,5";

            Assert.AreEqual(wait, fileContent);
        }        
    }
}
