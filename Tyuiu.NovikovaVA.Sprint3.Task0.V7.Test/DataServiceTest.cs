using Tyuiu.NovikovaVA.Sprint3.Task0.V7.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 0.75;
            int k1 = 1, k2 = 20;

            var sum = ds.GetSumSeries(a, k1, k2);
            double wait = -0.076;


            Assert.AreEqual(wait, sum);
        }
    }
}