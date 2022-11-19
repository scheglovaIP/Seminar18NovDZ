//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int number = ReadInt("Введите пятизначное число: ");

if(number<10000 || number>99999) Console.WriteLine("Это не пятизначное число!");
{
    int n1=number/10000%10;
    int n2=number/1000%10;
    int n4=number/10%10;
    int n5=number%10;
    if(n1==n5 && n2==n4)

    Console.WriteLine($"{number} - является палиндромом");
    else Console.WriteLine($"{number} - не палиндром");
}