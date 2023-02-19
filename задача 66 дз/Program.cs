Console.Clear();
Console.WriteLine("Введите начало промежутка: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец промежутка: ");
int b = Convert.ToInt32(Console.ReadLine());
int f (int a,int b)
{if(a==b)
return a;
return f(a+1,b)+a;
}
Console.Write($"сумма натуральных элементов в данном промежутке равна: {f(a,b)}");

