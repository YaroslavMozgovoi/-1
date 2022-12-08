// Напишите программу, которая из имеющегося массива строк форрмирует массив из строк, 
// длинна которых меньши либо равна 3 символам.



int LengthNewArray(string[] arr)    //Определение размера нового массива.
{
    int L = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3)L = L + 1;
    }
    return L ;
}
string[] NewArray(string[] arr, int lengh) //Создание и заполнение нового массива.
{
    int j = 0;
    string[] arrayC = new string[lengh];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3)
        {
            arrayC[j] = arr[i];
           j++;
        }
    }
    return arrayC;
}

void PrintArray(string[] array) //Вывод массива на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

string[] array = { "hello", "2", "world", ":-)", };
string[] arrayA = { "1234", "1567", "-2", "compter science" };
string[] arrayB = { "Rssia", "Denmark", "Kazan" };

int length = LengthNewArray(array);
string[] newArray = NewArray(array,length);
PrintArray(newArray);