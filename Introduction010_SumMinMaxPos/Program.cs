int[] A = { 9, 5, 8, 6, 19 };
int N = A.Length;
int posMax = 0; int posMin = 0;
int i = 0;
while (i < N)
{
    if (A[i] > A[posMax])
    {
        posMax = i;
    }
    if (A[i] < A[posMin])
    {
        posMin = i;
    }
    i += 1;
}
int leftPos = 0;
int rightPos = 0;
if (posMin < posMax) { leftPos = posMin; rightPos = posMax; } else { leftPos = posMax; rightPos = posMin; }
int k = leftPos + 1;
int Sum = 0;
while (k < rightPos)
{
    Sum += A[k];
    k += 1;
}
Console.WriteLine("Максимум " + A[posMax] + " c индексом " + posMax + ", минимум " + A[posMin] + " с индексом " + posMin);
Console.WriteLine("Сумма между позициями максимума и минимума, не включая концы отрезка, равна " + Sum);
