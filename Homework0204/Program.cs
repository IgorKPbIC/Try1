// 4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
string MainPassword = "GeekBrains";
string MainLogin = "root";
int count = 0;
do {
Console.WriteLine ("Введите логин");
string UserLogin = Console.ReadLine();
Console.WriteLine ("Введите пароль");
string UserPassword = Console.ReadLine();
if (UserLogin == MainLogin && UserPassword == MainPassword) {
Console.WriteLine("Добро пожаловать!");
break;
}
Console.WriteLine("Неверно указан логин или пароль");
count++;
} while (count < 3);