// 3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
int sum = 0;
int a = -1;
while (a != 0)
{
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
    if (a > 0 && a % 2 != 0)
    {
    sum += a;
    }

}
Console.WriteLine("Сумма чисел равна: " + sum);