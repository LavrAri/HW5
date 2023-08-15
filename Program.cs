// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array1 = GetArray(4, 100, 999);
Console.WriteLine($"[{String.Join(",",array1)}]");

int Sum = 0;

foreach (int el in array1){
Sum += (el % 2 != 0)  ?  0 : 1;
}
Console.WriteLine(Sum);

//Method array
int [] GetArray(int size, int minValue, int maxValue) {
int [] result = new int[size];
for(int i = 0; i < size; i++){
result[i] = new Random().Next(minValue,maxValue + 1);
}
return result;
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int [] array2 = GetArray(6, 1, 10);
// Console.WriteLine($"[{String.Join(",",array2)}]");

// int SumNumber = 0;

// for (int i = 0; i < array2.Length; i++){
// SumNumber += array2[i];
// i += 1;
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах = {SumNumber}]");

// //Method array
// int [] GetArray(int size, int minValue, int maxValue) {
// int [] result = new int[size];
// for(int i = 0; i < size; i++){
// result[i] = new Random().Next(minValue,maxValue + 1);
// }
// return result;
// }

//Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 4, 1, 77, 65] => 77 - 1 = 76

// int [] array3 = GetArray(5, 1, 100);
// Console.WriteLine($"[{String.Join(",",array3)}]");

// int minNum = array3[0];
// int maxNum = array3[0];


// foreach (int el in array3){
// minNum = minNum > el ? el : minNum;
// maxNum = maxNum < el ? el : maxNum;
// }

// int result =  maxNum - minNum;

// Console.WriteLine($"Разница между максимальным значением {maxNum} и минимальным {minNum} = {result} ");

// //Method array
// int [] GetArray(int size, int minValue, int maxValue) {
// int [] result = new int[size];
// for(int i = 0; i < size; i++){
// result[i] = new Random().Next(minValue,maxValue + 1);
// }
// return result;
// }