// Найти максимальное из трех чисел

Console.Write("Введите первое число  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число  ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число  ");
int c = Convert.ToInt32(Console.ReadLine());



int max =a;

if (b>a) max = b;
if (c>b) max = c;

Console.WriteLine ("max = ");
Console.Write (max );