Console.Write("Введите первое число: ");

int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

int C = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите четвертое число: ");

int D = Convert.ToInt32(Console.ReadLine());

float result = (float)(A + B + C + D) / 4;

Console.WriteLine("Среднее арифметическое из 4 чисел равно " + result);