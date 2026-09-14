using Tyuiu.SadykovSV.Sprint1.Task6.V8.Lib;
namespace Tyuiu.SadykovSV.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "Привет Мир";
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "риветП ирМ";
            Assert.AreEqual(wait, res);
        }
    }
}
