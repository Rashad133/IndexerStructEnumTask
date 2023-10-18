using Indexer_Home_Task_18._10.Models;

namespace Indexer_Home_Task_18._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt arr = new ListInt();

            arr.Add(4);
            arr.Add(6);
            arr.Add(8);

            arr.AddRange(5,6,7,8,9);

            //arr.Remove();
            //arr.RemoveRange();

            Console.WriteLine("Sum: "+arr.Sum);
            Console.WriteLine("Contains: "+arr.Contains(7));
            Console.WriteLine("arr: ", arr.ToString());



        }
    }
}