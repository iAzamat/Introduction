int[] A = { 9, 5, 8, 6, 19 };
int N = A.Length;
int i = 0;

Console.WriteLine("Заданный массив");
var str = string.Join(" ", A);
Console.WriteLine(str);

while (i < N / 2)
{
    int temp = A[i];
    A[i] = A[N - 1 - i];
    A[N - 1 - i] = temp;
    i += 1;
}

Console.WriteLine("Перевернутый массив");
var str2 = string.Join(" ", A);
Console.WriteLine(str2);
