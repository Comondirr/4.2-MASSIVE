using System;
class Task4
{
    static int get_n()
    {
        Console.Write("N: ");
        int n = Int32.Parse(Console.ReadLine());

        if (n < 0)
            throw new Exception("wrong n");
        return n;
    }

    static void print(int[,] array, int n, int m, String name)
    {
        Console.WriteLine(name + ": ");
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }

    static void Main()
    {
        int n = get_n();
        int m = n;
        int[,] a = new int[n, m];

        int value = 1;
        for (int i = 0; i < n; ++i)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = value;
                    value++;
                }
            }
            else
            {
                for (int j = m - 1; j >= 0; --j)
                {
                    a[i, j] = value;
                    value++;
                }
            }
        }

        print(a, n, m, "A");
    }
}