
Console.Clear();
Console.WriteLine("M: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N: ");
int n= Convert.ToInt32(Console.ReadLine());
int f(int M,int N)
{if(N==n)
return N;
Console.Write(N);
return f(M,N+1);
}
Console.WriteLine(f(m,m));