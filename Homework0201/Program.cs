// 1.	Написать метод, возвращающий минимальное из трёх чисел.
int min = 0;
Console.WriteLine ("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b && a < c)
{
   min = a;
}
else if (b < c)
{
    
     min = b;
}
else {
    min = c;
}
System.Console.WriteLine("Минимальное число: " + min);