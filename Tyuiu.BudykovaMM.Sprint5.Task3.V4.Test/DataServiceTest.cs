using System.IO;
using Tyuiu.BudykovaMM.Sprint5.Task3.V4.Lib;
namespace Tyuiu.BudykovaMM.Sprint5.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekcedExistsFile()
        {
            DataService ds = new DataService();
          
            string path = ds.SaveToFileTextData(3);
            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            Assert.IsTrue(fileExists);
        }  
    }
}
