// Задача 5. Составьте блок-схему на основе псевдокода
int[] numbers = { 1, 8, 3, 8, 2, 6, 8, 8 };
int index = 0;
int maximum = numbers[index];
int count_maximal = 0;
while (index < numbers.Length)
{
    if (numbers[index] > maximum)
    {
        maximum = numbers[index];
        count_maximal = 1;
    }
    else
    {
        if (numbers[index] == maximum)
        {
            count_maximal += 1;
        }
    }
    index += 1;
}
Console.WriteLine("Максимум равен " + maximum + ", в количестве: " + count_maximal + " шт.");
