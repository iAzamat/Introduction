int factorial = 1;
Console.WriteLine("Введите число, факториал которого нужно вычислить:");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    factorial = factorial * i;
}
Console.WriteLine("Факториал числа " + N + " равен " + factorial);
