using System;
// !Void метод 1
/*
void Method (string msg)
{
    Console.WriteLine(msg);
} 

Method("Text");

// !Void метод 2
/*
void Method (string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
} 

Method(msg: "Text", count: 4);
/*/

//! int метод 1 
/*
int Method3()
{
    return DateTime.Now.Year;
} 

int year = Method3();
Console.WriteLine(year);
/*/

//! int метод 2
/*
string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty; //или ""
    while (i<count)
    {
        result=result+text;
        i++;
    }

    return result;
} 

string res = Method4(10, "asdf");
Console.WriteLine(res);
/*/

// !FOR 
/*
string Method4(int count, string text)
{
    string result = String.Empty; //или ""
    for (int i=0; i<count; i++)
    {
        result=result+text;        
    }
    return result;
} 

string res = Method4(10, "asdf");
Console.WriteLine(res);
/*/

// !Цикл в цикле
//Таблица умножения
/*
for (int i=2; i<=10; i++ )
{
        for (int j=2; j<=10; j++ )
    {
        Console.WriteLine($"{i} x {j})={i*j}");        
    }
    Console.WriteLine();
}
/*/

//! Дан текст. В тексте нужно все пробелы заменить черточками, 
//! маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//! маленькими “с”. 
/*
string text = " — Я думаю, — сказал князь, улыбаясь, — что,"
                +" ежели бы вас послали вместо нашего милого "
                +" Винценгероде, вы бы взяли приступом согласие "
                +" прусского короля. Вы так красноречивы. Вы "
                +" дадите мне чаю?";

// string s = "qwerty" 
//             01234
// s[3] // - к

string Replace (string text, char oldValue, char newValue) //входной текст+старый символ +символ на который будем менять
{
    string result = String.Empty; // инициализация пустой строки

    int length = text.Length ; //получить длину строки
    for (int i=0; i< length; i++) //от 0 символа до конца строки 
    {
        if (text[i] == oldValue)  result = result+$"{newValue}";// если тек символ совпал с искомым символом то в результат должны положить новый
        else  result = result + $"{text[i]}";     
                // если совпадений необноружено то оставляем символ какой был          
    }
    return result;
} 

string newText =Replace (text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace (text, 'р', '*');
Console.WriteLine(newText);
/*/

//!Упорядочить массив
//Алгоритм сортировки максимальный


int [] arr = {1,5,6,8,2,7,9,3,1}; //массив 

void PrintArray(int[] array) //вывести массив на экран. Приходит Аргумент массив.  
{
    int count = array.Length; //получение количества элементов

    for (int i = 0; i<count; i++) // пробегаем по всем элементам массива и показываем на экране
    {
       Console.Write($"{array[i]} "); //вывод массива
    }
    Console.WriteLine();
}

void SelectionSort(int[] Array) // метод подбора
{
    for (int i=0; i<Array.Length -1; i++) //если начинаем поиск с i+1, тогда мы должны 1 единицу отнять i<Array.Length -1
    {
        int minPosition=i; // начальная позиция
        
         for (int j = i+1; j<Array.Length; j++) //начинаем с отсартированного места j = i+1
         {
            //ищем минимальный. Текущий меньше элемента котрый находиться на minPosition. 
            //то сохраняем minPosition (minPosition=j) 
            if (Array[j]<Array[minPosition]) minPosition=j; 
            
         }
        
        int temporary=Array[i]; // Замена позиции через темп 
        Array[i]=Array[minPosition]; // в i кладем минимальную
        Array[minPosition]=temporary; // кладем временный элемент
    }
} 

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
