/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int a = (int)Math.Log10(number)-2;
    Console.WriteLine(a < 0 ? "Третье число отсутствует" 
        : (number % (int)Math.Pow(10, a + 1) / (int)Math.Pow(10, a)).ToString());