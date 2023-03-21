Console.Clear();
Console.WriteLine ("Введите трёхзначное число: ");
string a = Console.ReadLine ()!;
int sum = 0;
    while(Convert.ToInt32(a) < 100 && Convert.ToInt32(a) > 999)
        {
        Console.WriteLine ("Введите трёхзначное число: ");
        a = Console.ReadLine ()!;
        }
Console.WriteLine(Convert.ToInt32(a[0].ToString()) + Convert.ToInt32(a[1]. ToString));



