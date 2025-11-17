using Tyuiu.BudykovaMM.Sprint5.Task1.V15.Lib;
using System.IO;
namespace Tyuiu.BudykovaMM.Sprint5.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekcedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);
            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
