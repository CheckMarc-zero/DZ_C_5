int N = insertNumberInt("Введите число членов массива:");


if ( N<0 ) Console.WriteLine("Введены некорректные данные.");
else if (N == 0) Console.WriteLine("Массив пуст.");
else
{
double[] massiv = genArray(N);
Console.Write("Полученный массив: ");
outMassiv(massiv);

double massivMin = massiv[0];
double massivMax = massiv[0];

for (int i = 0; i<N; i++)
{
if (massivMax < massiv[i]) massivMax = massiv[i];
if (massivMin > massiv[i]) massivMin = massiv[i];
}

Console.WriteLine($"Максимальное значение в массиве: {massivMax}");
Console.WriteLine($"Минимальное значение в массиве: {massivMin}");
Console.WriteLine($"Разница между ними: {massivMax - massivMin}");
}

//Метод ввода данных int
int insertNumberInt (string message)
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод генерации массива 
double [] genArray (int n)
{
    double[] A = new double[n];
    for (int i = 0; i<n; i++) A[i] = (new Random().NextDouble() * 1000);
    return A;
}

//Метод вывода массива
void outMassiv (double [] array)
{
for (int i = 0; i < N; i++)
{
    if (i == 0) Console.Write("[ ");
    Console.Write(array[i]);
    if (i == N-1) Console.WriteLine(" ]");
    else Console.Write(", ");
}
}
