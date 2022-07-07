int[] A = { 9, 5, 8, 6, 19 };
int N = A.Length;
int i = 0;
double Avg = 0;
int Sum = 0;

Console.WriteLine("Заданный массив");
var str = string.Join(" ", A);
Console.WriteLine(str);

while (i < N)
{
    Sum += A[i];
    i += 1;
}
Avg = (double)Sum / N;
Console.WriteLine("Среднее арифметическое равно " + Avg);
