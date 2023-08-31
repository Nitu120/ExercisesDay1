namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mathTable = new int[10,5];
            Console.WriteLine($"\t0\t1\t2\t3\t4");
            Console.WriteLine($"\t--\t--\t--\t--\t--");
            for (int i = 0; i < mathTable.GetLength(0); i++) // 10
            {
                Console.WriteLine($"{i} |\t");
                for (int j = 0; j < mathTable.GetLength(1); j++) // 5
                {
                    mathTable[i, j] = i * j; // multiplication table
                    Console.Write($"{mathTable[i,j],6}");
                }
                Console.WriteLine();
            }
        }
    }
}