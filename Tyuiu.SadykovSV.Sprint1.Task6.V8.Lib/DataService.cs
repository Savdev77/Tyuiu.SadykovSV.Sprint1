using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SadykovSV.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');
            string[] resultWords = new string[words.Length];
            int i = 0;
            foreach (var word in words)
            {
                if (word.Length == 0)
                {
                    i++;
                    continue;
                }
                else
                {
                    resultWords[i] = word[1..] + word[0];
                    i++;
                }
            }
            return string.Join(" ", resultWords);
        }
    }
}
