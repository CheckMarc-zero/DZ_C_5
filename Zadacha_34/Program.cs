int N = insertNumber("Введите число членов массива:");
int count = 0;

if ( N<0 ) Console.WriteLine("Введены некорректные данные.");
else if (N == 0) Console.WriteLine("Массив пуст.");
else
{
int[] massiv = genArray(N,100,999);
Console.Write("Полученный массив: ");
outMassiv(massiv);

for (int i = 0; i<N; i++)
{
if (massiv[i]%2 == 0) count++;
}

Console.WriteLine($"Колличество четных элементов в массиве: {count}");
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