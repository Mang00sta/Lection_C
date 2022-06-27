// Задача 9

    // "2" Функция 
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
// 1я линия это решение "Стихийный подход"
// - "1" "2"  - инициация значений
/*
int a1=15;
int b1=21;
int c1=39;
int a2=12;
int b2=23;
int c2=33;
int a3=12;
int b3=23;
int c3=331;
*/
        // "3" Вместо блока выше "Инициация значений"
        //             0  1  2  3 ........     8
        int[] array = {11,21,31,41,15,61,17,18,91};
        // "3" 
        //array [0]=12; //присвоили 0му число 12
        //Console.WriteLine(array[4]); //
    /* "2" 
    int max1=Max (a1, b1, c1);
    int max2=Max (a2, b2, c2);
    int max3=Max (a3, b3, c3);
    int max = Max(max1,max2,max3);
    */
    // "2" или 1й строкой
    //int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
            // "3" заменяем строку выше  
            int result = Max(
                Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8])
            );

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
*/
// "1" "2"
Console.WriteLine(result);

//проверка нового app 
