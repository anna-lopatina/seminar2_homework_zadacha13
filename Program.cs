// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет

Console.Clear();
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
if(a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else {
    if(a < 1000) {
        int b = a % 10;
        Console.WriteLine($"Выводим {b}");
    } else {
        int i = 10;
        int c = a / i;
        while (c > 999) 
        {
            i = i * 10;
            c = a / i;
        }
        int d = c % 10;
        Console.WriteLine($"Выводим {d}");
    }
}
