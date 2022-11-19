// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int number = ReadInt("Введите число: ");
int i = 1;

if(number<1)
{
    while(number<i)
    {
        Console.Write(i*i*i + ", ");
        i--;
    }
}
else if(number>1)
{
    while(i<number)
    {
        Console.Write(i*i*i + ", ");
        i++;
    }
}
Console.WriteLine(i*i*i);