int[] numbers = { 1, 8, 3, 2, 6 };
int size = 5;
int index = 0;
int max = numbers[0];
while (index < size)
{
    if (numbers[index] > max)
    {
        max = numbers[index];
    }
    index++;
}
Console.WriteLine("Максимальное число найдено и равно " + max);
