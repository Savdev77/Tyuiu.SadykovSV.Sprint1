using Tyuiu.SadykovSV.Sprint1.Task2.V8.Lib;
namespace Tyuiu.SadykovSV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 10;
            var result = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(30, result);
        }
    }
}
