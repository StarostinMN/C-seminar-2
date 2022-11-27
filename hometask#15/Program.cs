/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Пример: 6 -> да, 7 -> да, 1 -> нет */
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = (int.Parse(Console.ReadLine()));
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else if (day >= 1 & day <= 5)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Введенная цифра должна быть от 1 до 7");
}