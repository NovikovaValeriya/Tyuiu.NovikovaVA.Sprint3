using Tyuiu.NovikovaVA.Sprint3.Task3.V10.Lib;
namespace Tyuiu.NovikovaVA.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "gdfppf vfppt p";
            char chr = 'p';
            string res = ds.DeleteCharInString(str, chr);
            string wait = "gdff vft ";
            Assert.AreEqual(wait, res);
        }
    }
}