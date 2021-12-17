// 5.	а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
Console.WriteLine ("Укажите Ваш рост в метрах: ");
double h = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Укажите Ваш вес в киллограмах: ");
double w = Convert.ToDouble(Console.ReadLine());
double Index = w/Math.Pow(h, 2);
Console.WriteLine ($"Ваш индекс массы, равен " + Index);
if (Index > 25)
{
    double Wdown = (Index - 25)*Math.Pow(h, 2);
    Console.WriteLine ("Вам нужно скинуть " + Wdown + " киллограм");}
else if (Index < 18.5) 
{   double Wup = (18.5 - Index)*Math.Pow(h, 2);
    Console.WriteLine ("Вам нужно набрать " + Wup + " киллограм");}
else {Console.WriteLine ("У Вас нормальный вес");}