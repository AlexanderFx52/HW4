Console.Clear();
Console.WriteLine ("Введите трёхзначное число: ");
string a = Console.ReadLine ()!;
    while(Convert.ToInt32(a) < 100 || Convert.ToInt32(a) > 999)
        {
        Console.WriteLine ("Введите трёхзначное число: ");
        a = Console.ReadLine ()!;
        }
Console.WriteLine($"Сумма цифр в этом числе = {(Convert.ToInt32(a[0]. ToString()))+(Convert.ToInt32(a[1]. ToString()))+(Convert.ToInt32(a[2]. ToString()))}");



