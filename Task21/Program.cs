/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int ReadInt(string message)
{
Console.Write(message + " -> ");
return Convert.ToInt32(Console.ReadLine());
}


int xA = ReadInt("Введите координату X точки А: ");
int yA = ReadInt("Введите координату Y точки А: ");
int zA = ReadInt("Введите координату Z точки А: ");

int xB = ReadInt("Введите координату X точки B: ");
int yB = ReadInt("Введите координату Y точки B: ");
int zB = ReadInt("Введите координату Z точки B: ");



double root = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
Console.WriteLine(root);