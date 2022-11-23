/*
Сначала определим новый массив. Пусть это будет массив под именем array. 
Далее укажем, что в этом массиве будет по умолчанию 10 элементов. 
Запомним новую конструкцию new int [10], которая дословно означает «создай новый массив, где будет 10 элементов». 
По умолчанию он будет наполнен нулями. Чтобы заполнить массив случайными числами, воспользуемся методом, который опишем сами:
*/
int[] array = new int[10];
/*
Начнём с ключевого слова void. Далее дадим наименование нашему методу FillArray. 
В качестве аргумента будет приниматься какая-то коллекция, то есть аргумент collection. 
Затем нам надо получить длину нашего массива. Делается это посредством collection.Length. 
На следующем этапе возьмём позицию index, которая по умолчанию будет начинаться с 0. 
Теперь в цикле while пропишем index < length. И index = index + 1
*/
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
// После этого обратимся к аргументу collection на позицию index и положим туда новое случайное число — целое число из диапазона 1–10.
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

/*
Теперь попробуем адаптировать решение предыдущей задачи, в которой находили нужные элементы и позицию нужного элемента в массиве.
Для этого потребуется описать метод, отличный от void. Он будет возвращать позицию, то есть index. 
Назовём этот метод IndexOf, а в качестве аргумента будет приходить массив collection и какой-то элемент find.
Далее определяем количество элементов через count — collection.Length. Нам потребуются индексы, чтобы щёлкать массив, пусть это будет переменная index.
Затем возьмём цикл while, который будет проверять index < count. Ведём в фигурные скобки index++. 
Напишем следующее: если collection[index] совпал с find, потребуется куда-то сохранить позицию. Чтобы её куда-то сохранить, определим новую переменную position. 
И пусть по умолчанию это будет 0. Это не совсем общее решение, но пока подойдёт.
В position положим значение нашего индекса. После того как этот цикл отработает, ожидаем return position, нашу позицию элемента.
*/

int IndexOf(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position = -1;
while (index < count)
{
    if(collection[index] == find)
    {
        position = index;
        break;
    }
    index++;
}
return position;
}

FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array, 444);
Console.WriteLine(pos);