/* Задача 19: Напишите программу,которая принимает
//  на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да*/

Console.Clear();
Console.Write("Ввведите любое пятизначное число n: ");
int n = int.Parse(Console.ReadLine());
int s1 = n % 10;
int s2 = n / 10000;
int s3 = (n % 100 - n % 10) / 10;
int s4 = n / 1000 - n / 10000 * 10;
if (n > 99999 || n < 10000)
{
    Console.WriteLine("число введено неправильно");
}
while (n > 9999 && n < 100000)
{
    if (s1 == s2 && s3 == s4) {
        Console.WriteLine($"число {n} является палиндромом");
        break;
    }
    if (s1 != s2 || s3 != s4) {
        Console.WriteLine($"число {n} не является палиндромом");
        break;
    }
    
}




    
            
        









/* Задача 21: Напишите программу, которая принимает
//  на вход координаты двух точек и находит расстояние между ними
//   в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53*/

/* Задача 21: Напишите программу, которая принимает
//  на вход координаты двух точек и находит расстояние между ними
//   в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
Console.Write("Введите координаты точки А по оси x: ");
double a1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки А по оси y: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки А по оси z: ");
double c1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки В по оси x: ");
double a2 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки В по оси y: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки В по оси z: ");
double c2 = double.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2) + Math.Pow(c1 - c2, 2));
Console.WriteLine($" Расстояние между двумя точками А и В в 3D пространстве distance = {distance:f2}");



/* Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i*i}, ");
}