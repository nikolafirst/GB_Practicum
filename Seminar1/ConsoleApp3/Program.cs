/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.Write("Введите пожалуйста целое число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
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

    default:
    Console.WriteLine("Дни недели закончились :))");
    break;

}


