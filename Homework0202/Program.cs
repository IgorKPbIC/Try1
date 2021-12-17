// 2.	Написать метод подсчета количества цифр числа.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (a != 0)
{
    count++;
    a = a/10;
}
Console.WriteLine("Количество цифр в числе: " + count);