/* 
Задача 19.

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/


//                                                     Вариант решения №1.
int ReadInt(string message)
{
Console.Write(message + " -> ");
return Convert.ToInt32(Console.ReadLine());
}
void Rer(int x, int y)
{
if(x > 9999 && x < 100000)
{
    if(x == y)
    {
    Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
else 
{
    Console.WriteLine("Вы ввели не пятизначное число" + "  :(" );
}

}

int number = ReadInt("Введите пятизначное число");

int n = 0;
int run = 1;
int lin = 10000;
int number2 = 0;
while(n<5)
{
   int y  = ((number / run) %10) * lin;
   number2 = number2 + y;
    run *=10;
    lin /=10;
    n++;
 
}

Rer(number, number2);



//                                                         Решение №2
/* 
int ReadInt(string message)
{
Console.Write(message + " -> ");
return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите пятизначное число");

int i = 0;
int pub = 1;
int[] myArray = new int[5];
while(i < 5)
    {
         myArray[i] = (number / pub )%10;
        i++;
        pub *= 10;

    }
    
if(number > 9999 && number < 100000)
{
    if(myArray[0] == myArray[4] && myArray[1] == myArray[3])
    {
       Console.WriteLine("ДА"); 
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
else 
{
    Console.WriteLine("Вы ввели не пятизначное число" + "  :(" );
}
*/
//                                                      Вариант решения №3.

/*
int ReadInt(string message)
{
Console.Write(message + " -> ");
return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите пятизначное число");

int Num(int x, int y)
{
    int result = (x / y) % 10;
    return result;
} 

int a = Num(number,1);                     
int b = Num(number,10);                   
int c = Num(number,100);                 
int d = Num(number,1000);               
int e = Num(number,10000);             
int number2 = (a * 10000) + (b * 1000) + (c * 100) + (d * 10) + e;

Rer(number, number2);

*/
