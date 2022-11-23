int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// Вместо стандартного перечисленния переменных, введём массив:
int[] array = {11,2221,31,555,51,61,71,81,91};
// как теперь исправить код ниже?
/*
int max = Max (Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
*/
// обратимся к массиву и запишем в него значение
array[0] = 12;
// обратиться к массиву и получить значение соот-его элемента по указанному индексу
Console.WriteLine(array[5]);

int result = Max (
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]),
    Max (array[6], array[7], array[8])
);
Console.WriteLine(result);