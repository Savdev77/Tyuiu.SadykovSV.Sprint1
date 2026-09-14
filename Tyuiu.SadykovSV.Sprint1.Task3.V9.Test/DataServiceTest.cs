using Tyuiu.SadykovSV.Sprint1.Task3.V9.Lib;
namespace Tyuiu.SadykovSV.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 90;
            double res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(1.5, res);
        }
    }
}
