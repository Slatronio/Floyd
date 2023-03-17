class Porgram
{
    static void Main()
    {
        Console.Write("Введите количество вершин графа: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] a = new int[n, n];
        int[,] b = new int[n, n];
        Console.WriteLine();
        Console.WriteLine("Введите весовую матрицу:");
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(" ");
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    a[i, j] = 0;
                    continue;
                }
                int t = Convert.ToInt32(s[j]);
                if (t == 0)
                {
                    a[i, j] = Int32.MaxValue;
                    continue;
                }
                a[i, j] = t;
            }
        }
        Console.WriteLine();
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine("(" + (k+1) +")==========================");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int t = a[i, k] + a[k, j];
                    if ((a[i, k] == Int32.MaxValue) || (a[k, j] == Int32.MaxValue)) t = Int32.MaxValue;
                    a[i, j] = Math.Min(t, a[i, j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] >= Int32.MaxValue) Console.Write("0 ");
                    else Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("=============================");
    }
}