using Tyuiu.NovikovaVA.Sprint3.Task1.V6.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int a = 4;
            int k1 = 1;
            int k2 = 10;
            var res = ds.GetSumSeries(a, k1, k2);
            double wait = -389102.25;
            Assert.AreEqual(wait, res);
        }
    }
}