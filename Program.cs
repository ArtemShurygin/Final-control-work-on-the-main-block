/*
    Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

int j = 0;

Console.WriteLine("Введите количество элементов (строк):");
int n = Convert.ToInt32(Console.ReadLine());
string [] input_array = new string [n];
string [] output_array = new string [n];

for (int i=0; i<n; i++) {
    Console.WriteLine($"Введите  элемент (строку) №{i+1}:");
    input_array [i] = Convert.ToString(value: Console.ReadLine());
    if (input_array[i].Length < 4) {
        output_array [j] = input_array [i];
        j++;
    }
}

Console.WriteLine();
Console.WriteLine("Исходный массив: ");
for (int i=0; i<n; ++i) {
    Console.WriteLine(input_array [i]);
}

Console.WriteLine();
if (j==0) {
    Console.WriteLine("Нет строк, длина которых меньше, либо равна 3 символам: ");
}
else {
    Console.WriteLine("Строки, длина которых меньше, либо равна 3 символам: ");
    for (int i=0; i<j; i++) 
    Console.WriteLine(output_array [i]);
}
