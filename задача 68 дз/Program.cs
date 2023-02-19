Console.Clear();
Console.WriteLine("Введите первое не отрицательное число: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе не отрицательное число: ");
int n =Convert.ToInt32(Console.ReadLine());
int f(int m,int n)
{

if (m>0 && n==0)
return f(m-1,1);
if (m>0 && n>0)
return f(m-1,f(m,n-1));
return n+1;}
Console.WriteLine(f(m,n));