// Задача 9 Имеем одномерный массив array из n элементов 
// Найти эллемент массива равный find. 

int[] array = {1, 12, 31, 4, 15, 16, 17, 18}; //определяем массив

int n = array.Length; //array.Length количество элементов в массиве
int find = 18; //пользователь вводит число ???

int index=0; //устанавливаем счетчик index

while (index < n) 
{
    if (array[index]==find) // 
    {
        Console.WriteLine(index);
        break; // прирывает алгоритм
    }
    
    index++;
}



