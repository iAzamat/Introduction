int[] firstVector = { 1, 8 };
int[] secondVector = { 6, 3 };
int scalarProduct = 0;
int index = 0;
if (firstVector.Length == secondVector.Length)
{
    int size = firstVector.Length;
    while (index < size)
    {
        scalarProduct = scalarProduct + firstVector[index] * secondVector[index];
        index+=1;
    }
    Console.WriteLine("Скалярное произведение равно " + scalarProduct);
}
else Console.WriteLine("Размерности векторов не совпадают, пожалуйста исправьте "); 
