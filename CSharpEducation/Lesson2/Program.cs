namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            var array = GetArray(N);
            for (int i = 0; i < N; i++) 
            {
                array[i] = i;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(i);
                if (i < N - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        public static int[] GetArray(int n)
        {
            return new int[n];
        }
    }
}