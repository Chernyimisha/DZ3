/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int[] pointA = new int[3];
int[] pointB = new int[3];

Console.WriteLine("Введите координаты точки А: ");
Console.Write("X: ");
pointA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
pointA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
pointA[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
pointB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
pointB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
pointB[2] = Convert.ToInt32(Console.ReadLine());

Console.Write($"({pointA[0]},{pointA[1]},{pointA[2]})");
Console.Write($"({pointB[0]},{pointB[1]},{pointB[2]})");

double distance = Distance(pointA[0], pointA[1], pointA[2],
                            pointB[0], pointB[1], pointB[2]);

Console.Write($" ->{distance}");

double Distance(int x1, int y1, int z1,
                 int x2, int y2, int z2)
{
    int x = (x2 - x1) * (x2 - x1);
    int y = (y2 - y1) * (y2 - y1);
    int z = (z2 - z1) * (z2 - z1);
    double result = Math.Sqrt(x + y + z);
    result = Math.Round(result, 2);
    return result;
}



// int[] point1 = new int[3];
// int[] point2 = new int[3];

// FillArray(point1);
// FillArray(point2);

// double distance = Math.Round ((Math.Sqrt(Math.Pow((point2[0]-point1[0]),2)
// +Math.Pow((point2[1]-point1[1]),2)+Math.Pow((point2[2]-point1[2]),2))),2);

// Console.Write ($"({point1[0]},{point1[1]},{point1[2]})");
// Console.Write ($"({point2[0]},{point2[1]},{point2[2]})");
// Console.Write ($" ->{distance}");

// void FillArray(int[] coordinates)
// {
//     int length = coordinates.Length;
//     int index = 0;
//     while (index < length)
//     {
//         coordinates[index] = new Random().Next(-10, 10);
//         index++;
//     }
// }
