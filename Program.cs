// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//   лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string [] array = new string [8] {"Hellooooo","2","world","123","test","One","two","three"};
string [] array2=new string [array.Length];


int count=0;
for (int i = 0; i < array.Length; i++)
{
       int n =array[i].Length;

        if (n<=3)
    {
        array2[count]=array[i];
        Console.Write(array2[count]+", ");
        count++;
    }
}
