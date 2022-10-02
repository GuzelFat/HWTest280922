﻿// 1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой 
//основной содержательной части, если вы выделяете её в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом 
//(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 
//должны быть расположены в разных коммитах)

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
//с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → [];

System.Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine());
string[] array1 = new string[n];

for (int i = 0; i < n; i++)
{
    array1[i] = Console.ReadLine();
}

for (int i = 0; i < n; i++)
{
    System.Console.Write(array1[i] + " ");
}

 string[] array2 = new string[array1.Length];
int count = 0;
 for (int i = 0; i < array1.Length; i++)
    {
     if(array1[i].Length <= 3)
     {
       array2[count]=array1[i];
         count++;
     }
    }

     for (int i = 0; i < array1.Length; i++)
     {    System.Console.Write(array1[i]); 
       System.Console.Write(" ");
     }
     System.Console.WriteLine();

     for (int i = 0; i < array2.Length; i++)
     {
         System.Console.Write(array2[i]);
            System.Console.Write(" ");
     }




