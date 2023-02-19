Console.Clear();
Console.WriteLine("Vvedite chislo: ");
int N= Convert.ToInt32(Console.ReadLine());

int f(int N)
{if(N/10==0)
return N;

return f(N/10)+N%10;

}
Console.Write(f(N));
