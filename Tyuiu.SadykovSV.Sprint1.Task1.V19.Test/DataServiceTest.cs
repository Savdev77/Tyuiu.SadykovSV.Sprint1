using Tyuiu.SadykovSV.Sprint1.Task1.V19.Lib;
namespace Tyuiu.SadykovSV.Sprint1.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
