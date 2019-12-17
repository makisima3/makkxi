using CustomGenericStructures;
using System;

namespace Functions
{
    public class FunctionsForWorkingWithLists
    {
        private static Random rnd = new Random();

        public static void RandomFill(IList<double> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(rnd.NextDouble());
            }
        }

        public static void ConsoleWriteList(IList<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
