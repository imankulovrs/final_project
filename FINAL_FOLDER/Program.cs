/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < array.GetLength(0); i++) {
          array[i] =  Console.ReadLine() ?? "";
}

Console.WriteLine("Результат");
for (int i = 0; i < array.GetLength(0); i++) {
    if(array[i].Length <= 3 && array[i].Length > 0){
        Console.Write(array[i]);
        Console.WriteLine();
    }
          
}
