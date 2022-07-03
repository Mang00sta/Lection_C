// !Задача 1
/*/
Console.WriteLine("  2  Hello, World!");
/*/

//!Задача 2
/*/
Console.Write ("введите ");
string userName = Console.ReadLine();
Console.Write ("Привет, ");
Console.Write (userName);
/*/

//!Задача 3
/*/
int numberA = new Random ().Next(1,10);
Console.WriteLine (numberA);
int numberB = new Random ().Next(1,10);
Console.WriteLine (numberB);
int result = numberA + numberB;
Console.WriteLine(numberA + numberB);
/*/

//!Задача 4

/*/
double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA / numberB); 
/*/

//!Задача 5

/*/
Console.Write ("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine ("Ура это же Маша");
}

else 
{
    Console.Write ("привет, ");
    Console.WriteLine(username);
}
/*/

//!Задача 6

/*/
int a=1;
int b=2;
int c=6;
int d=8;
int e=4;

int max=a;

if(a >max) max =a;
if(b >max) max =b;
if(c >max) max =c;
if(d >max) max =d;
if(e >max) max =e;

Console.Write("max =");
Console.WriteLine (max);

/*/

//!Задача 7

/*/
Console.Clear();

int xa = 25, ya = 1,
    xb = 1, yb = 20,
    xc = 50, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x=xa, y=xb;

int count =0; 

while (count <10000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition (x,y);
    Console.WriteLine("+");
    count++;

}
/*/

//!Задача 8-9

/*/
    // "2" Функция 
    int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2>result) result=arg2;
        if (arg3>result) result=arg3;
        return result;
    }
// 1я линия это решение "Стихийный подход"
// - "1" "2"  
int a1=15;
int b1=21;
int c1=39;
int a2=12;
int b2=23;
int c2=33;
int a3=12;
int b3=23;
int c3=331;

    /* "2" 
    int max1=Max (a1, b1, c1);
    int max2=Max (a2, b2, c2);
    int max3=Max (a3, b3, c3);
    int max = Max(max1,max2,max3);
    */
    // "2" или 1й строкой
    //int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)  );

/* "1"
int max=1;

*/
// Заменяем все это функцией выше "2" Функция
/* "1"
if (b1>max) max =b1;
if (c1>max) max =c1;

if (a2>max) max =a2;
if (b2>max) max =b2;
if (c2>max) max =c2;

if (a3>max) max =a3;
if (b3>max) max =b3;
if (c3>max) max =c3;
/*

Console.WriteLine(max);

/*/

//!Задача 10 Имеем одномерный массив array из n элементов. Найти эллемент массива равный find. 

/*/

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

/*/

//!Задача 11

/*/
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

/*/
//Задача 12

/*/

/*/
//Задача 13

/*/

/*/
//Задача 14

/*/

/*/

//Задача 15

/*/

/*/
