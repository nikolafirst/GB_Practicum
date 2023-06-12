/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.WriteLine ("Введите пожалуйста целое число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

int number1 = 1;
int number2 = 2;
int number3 = 3;
int number4 = 4;
int number5 = 5;
int number6 = 6;
int number7 = 7;

switch (number) 
{
    case (1):
    Console.WriteLine("Поздравляем, сегодня Понедельник");
    break;

    case (2):
    Console.WriteLine("Поздравляем, сегодня Вторник");
    break;

    case (3):
    Console.WriteLine("Поздравляем, сегодня Среда");
    break;

    case (4):
    Console.WriteLine("Поздравляем, сегодня Четверг");
    break;

    case (5):
    Console.WriteLine("Поздравляем, сегодня Пятница");
    break;

    case (6):
    Console.WriteLine("Поздравляем, сегодня Суббота");
    break;

    case (7):
    Console.WriteLine("Поздравляем, сегодня Воскресенье");
    break;
}


