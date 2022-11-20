int a = new int();
int b = new int();
Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
    bool Chto0 = a > b;
    bool Chto1 = a < b;
        if (Chto0)
    {
     Console.Write("Max=");
     Console.WriteLine(a);
    }
        
    else if (Chto1)
    {
     Console.Write("Max=");
     Console.WriteLine(b);
    }                