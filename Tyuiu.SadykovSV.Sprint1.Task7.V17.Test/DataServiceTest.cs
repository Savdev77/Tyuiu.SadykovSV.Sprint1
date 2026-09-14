using Tyuiu.SadykovSV.Sprint1.Task7.V17.Lib;
namespace Tyuiu.SadykovSV.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4.871, res);
        }
    }
}
