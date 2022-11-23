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

FillArray(array);
PrintArray(array);