/*
    Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

Console.WriteLine("Введите количество элементов (строк):");
int n = Convert.ToInt32(Console.ReadLine());
string [] input_array = new string [n];
string [] output_array = new string [n];

for (int i=0; i<n; ++i) {
    Console.WriteLine($"Введите  элемент (строку) №{i+1}:");
    input_array [i] = Convert.ToString(value: Console.ReadLine());
    Console.WriteLine(input_array [i]);
    }
    
Console.WriteLine();
Console.WriteLine("Исходный массив: ");

for (int i=0; i<n; ++i) {
    Console.WriteLine(input_array [i]);
    }