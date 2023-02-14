// Даны два числа. Показать большее и меньшее.
int a=8;
int b=6;
int max;
int min;
if (a>b)
{
  max=a; min=b;
}
else
{
  max=b; min=a;
}
Console.Write("max = ");
Console.WriteLine( max );
Console.Write("min = ");
Console.WriteLine( min );