using Tyuiu.KorotkovNS.Sprint6.Task2.V29.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5, stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = new double[stop - start + 1];
            wait[0] = 28.05;
            wait[1] = 22.27;
            wait[2] = 17.01;
            wait[3] = 12.35;
            wait[4] = 7.51;
            wait[5] = 0;
            wait[6] = 1.62;
            wait[7] = -7.03;
            wait[8] = -12.99;
            wait[9] = -17.55;
            wait[10] = -21.43;

            CollectionAssert.AreEqual(wait, res);
        }
    }
}