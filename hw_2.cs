
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное число: ");

int number = (int)Convert.ToUInt32(Console.ReadLine());

int a = number / 100;
int b = number / 10 % 10;
int c = number % 10;

Console.Write("Вторая цифра числа: ");
Console.Write(b);


//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");

int number = (int)Convert.ToUInt32(Console.ReadLine());

while (number >= 1000)
{
    number /= 10;
}

if (number >= 100)
{
    int num_3 = number % 10;
    Console.WriteLine(num_3);
}

else
{
    Console.WriteLine("Третьего числа нет");
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введите число: ");

int number = (int)Convert.ToUInt32(Console.ReadLine());


if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота, выходной");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье, выходной");
}

else 
{
    Console.WriteLine("Нет дня недели для данного числа");
}
*/