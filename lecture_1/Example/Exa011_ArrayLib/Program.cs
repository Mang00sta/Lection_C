void FillArray(int[] collection) // Метод заполнения массива. Наименование метода -Collection это название 
{
    int Length = collection.Length; //длина массива
    int index =0;
    while (index<Length)
    {
        collection[index] = new Random ().Next (1, 10); //обращаемся в collection с индексом 
        // и получаем новое случайное число из диопазона 1-10
        index++;
    }
}
 
void PrintArray (int[] pri) // Имя метода "pri" метод который выводит на печать
{
    int count = pri.Length; // количество элементов
    int position =0; // текущая позиция
    while (position<count) 
    {
        Console.WriteLine(pri [position]); //значение текущего элемента
        position++;
    }
}
 
int indexOf(int[] collection, int find) //
{
    int count =collection.Length;
    int index = 0;
    int position=-1; //куда сохранить позицию. Если не встречаеться ни одного элемента ставим -1
    
    while (index<count)
    {
        if(collection [index] == find)
        {
            position = index; 
            break;
        }     
        index++;
    }
    return position;
}


int[] array = new int [10]; //определили массив из 10 элементов

FillArray (array); // метод - Заполнил массив
array[4]=4;
array[6]=4;
PrintArray (array); // метод - распечатал
Console.WriteLine ();

int pos=indexOf (array, 4); //ищем 4
Console.WriteLine(pos); 

//test
