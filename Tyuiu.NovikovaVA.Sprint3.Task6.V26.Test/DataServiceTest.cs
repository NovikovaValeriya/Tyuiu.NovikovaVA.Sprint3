using Tyuiu.NovikovaVA.Sprint3.Task6.V26.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 33;
            Assert.AreEqual(res, wait);
        }
    }
}