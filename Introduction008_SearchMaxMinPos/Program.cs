int[] A = { 9, 5, 8, 6, 19 };
int N = A.Length;
int posMax = 0;
int posMin = 0;
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
Console.WriteLine("Максимум " + A[posMax] + " c индексом " + posMax + ", минимум " + A[posMin] + " с индексом " + posMin);
