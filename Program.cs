Console.Clear();

//Задание 19
Console.WriteLine("Задание 19");
Console.WriteLine("Введите 5-ти значное число: ");
string N19 = Console.ReadLine();
if(N19[0]==N19[4] && N19[1] == N19[3])
{
    Console.WriteLine("Число " + N19 + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + N19 + " не является палиндромом");
}

//Задание 21
Console.WriteLine("Задание 21");
Console.WriteLine("Введите число X: ");
double X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y: ");
double Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Z: ");
double Z = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(X*X + Y*Y + Z*Z);
Console.WriteLine(distance);

//Задание 23
Console.WriteLine("Задание 23");
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 1; N >= i; i++)
{
    Console.Write(i*i*i + " ");
}
