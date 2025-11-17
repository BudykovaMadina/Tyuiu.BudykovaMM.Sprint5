using System.IO;
using Tyuiu.BudykovaMM.Sprint5.Task2.V24.Lib;
namespace Tyuiu.BudykovaMM.Sprint5.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekcedExistsFile()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3];
            string path = ds.SaveToFileTextData(mtrx);
            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
