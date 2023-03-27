Console.Clear();
Console.Write("Введите первое число: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите треттье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine("Первое число больше вторго");
}
if(num1>num3)
{
    Console.WriteLine("Первое число больше третьего");
}
if(num2>num3)
{
    Console.WriteLine("второе число больше третьего");
}
if(num1<num2)
{
    Console.WriteLine("Первое число меньше вторго");
}
if(num1<num3)
{
    Console.WriteLine("Первое число меньше третьего");
}
if(num2<num3)
{
    Console.WriteLine("второе число меньше третьего");
}
