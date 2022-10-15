int N = insertNumber("Введите число членов массива:");
int min = insertNumber("Введите минимум для членов массива:");
int max = insertNumber("Введите максимум для членов массива:");
int summNechet = 0;

if ( N<0 || min>max) Console.WriteLine("Введены некорректные данные.");
else if (N == 0) Console.WriteLine("Массив пуст.");
else
{
int[] massiv = genArray(N,min,max);
Console.Write("Полученный массив: ");
outMassiv(massiv);

for (int i = 0; i<N; i++)
{
if (i%2 != 0) summNechet = summNechet + massiv[i];
}

Console.WriteLine($"Сумма элементов с нечётными индексами в массиве = {summNechet}");
}


//Метод ввода данных
int insertNumber (string message)
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод генерации массива 
int [] genArray (int n, int minim, int maxim)
{
    int[] A = new int[n];
    for (int i = 0; i<n; i++) A[i] = new Random().Next(minim,maxim+1);
    return A;
}

//Метод вывода массива
void outMassiv (int [] array)
{
for (int i = 0; i < N; i++)
{
    if (i == 0) Console.Write("[ ");
    Console.Write(array[i]);
    if (i == N-1) Console.WriteLine(" ]");
    else Console.Write(", ");
}
}
