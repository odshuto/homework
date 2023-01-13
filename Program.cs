// Домашнее задание 3

int q = 0;
int w = 0;
int e = 0;
int r = 0;
Console.WriteLine("№19");
Console.WriteLine("Введите пятизначное число: ");
int pol = Convert.ToInt32(Console.ReadLine());

// Первое число с конца
r = pol % 10;

 // Второе число с конца
e = pol % 100 / 10;

 //Второе число 
w = pol % 10000 / 100 / 10;

// Первое число
q = pol / 10000;

if(q == r && w == e)
    Console.WriteLine("Да :)");
else
    Console.WriteLine("Нет :(");


Console.WriteLine("№21");

Console.WriteLine("Введите координаты точки 'A': ");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 'B': ");
Console.WriteLine("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));

Console.WriteLine($"Расстояние равно : {Math.Round(result,2)}");


Console.WriteLine("№23");

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i++)
    Console.WriteLine($"Куб числа [{i}] = {i * i * i}");