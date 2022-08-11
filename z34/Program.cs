// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

int[] numbers = new int[10];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int ValuePositive(int[] array){
    int value = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      value++;
    }
  }
  return value;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int value = ValuePositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {value}");

