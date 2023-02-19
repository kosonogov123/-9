int f(int a, int b)
{if (b==5)
return b;
Console.Write($"{b}, ");
return f(a,b+1)*a;
}
Console.Clear();
Console.WriteLine(f(1,1));