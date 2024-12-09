
using Tyuiu.KorotkovNS.Sprint6.Task6.V26.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V26.txt";
            DataService ds = new DataService();

            string res = ds.CollectTextFromFile(path);
            string wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw";
            Assert.AreEqual(wait, res);
        }
    }
}