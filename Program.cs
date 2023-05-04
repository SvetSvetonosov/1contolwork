//  Задача: Написать программу, которая из имеющегося массива строк 
//  формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  // Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  // При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

 // Примеры:
 // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
 // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
 // [“Russia”, “Denmark”, “Kazan”] → [ ]




 void SecondArray(string[] array, string[] arr)
 {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
     if(array[i].Length <= 3)
         {
         arr[count] = array[i];
         count++;
         }
     }
 }

 void PrintArray(string[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Console.Write($"{array[i]}\t ");
     }
     Console.WriteLine();
 }
 string[] array = new string[6] {"Russia", "23", "Fir", "2", "Kazan", "333"};
 string[] arr = new string[array.Length];
 SecondArray(array, arr);
 PrintArray(arr);