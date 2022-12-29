/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int[] point1 = new int[3];
int[] point2 = new int[3];

FillArray(point1);
FillArray(point2);

double distance = Math.Round ((Math.Sqrt(Math.Pow((point2[0]-point1[0]),2)
+Math.Pow((point2[1]-point1[1]),2)+Math.Pow((point2[2]-point1[2]),2))),2);

Console.Write ($"({point1[0]},{point1[1]},{point1[2]})");
Console.Write ($"({point2[0]},{point2[1]},{point2[2]})");
Console.Write ($" ->{distance}");

void FillArray(int[] coordinates)
{
    int length = coordinates.Length;
    int index = 0;
    while (index < length)
    {
        coordinates[index] = new Random().Next(-10, 10);
        index++;
    }
}
