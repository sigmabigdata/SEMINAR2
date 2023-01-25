/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int sunday = 1;
int monday = 2;
int tuesday  = 3;
int wednesday  = 4;
int thursday  = 5;
int friday = 6;
int saturday  = 7;

int day = int.Parse(Console.ReadLine());

if (day == 6 || day ==  7) 
{
    Console.WriteLine("Этот день Выходной");
}
else
Console.WriteLine("Этот день Рабочий");

