Console.Clear();
Console.WriteLine ("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите Второе число: ");
int b = int.Parse(Console.ReadLine()!);
int sum = a; 
int q = a;
    for(int i = 1; i < b; i++)
{   q = q * sum;
    
}
Console.WriteLine($"Ваше первое число {a} в степени {b} будет равно : {q}");