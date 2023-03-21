Console.Clear();
int n = 8;
int[] a = new int[n];
    for(int i = 0; i<a.Length; i++)
        a[i] = new Random(). Next(1, 101);
Console.WriteLine($"Вот твой массив, друг [{string.Join(", ", a)}]");