using Tyuiu.ZolotovaKA.Sprint6.Task0.V10.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValue()
        {
            DataService dataService = new DataService();
            int exp = 0;
            Assert.AreEqual(exp, dataService.Calculate(0));
        }
    }
}