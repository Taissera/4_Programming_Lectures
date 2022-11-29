﻿/*
---------------------------------------------------------------
-------------------Первая группа методов ----------------------
---------------------------------------------------------------
*/
void Method1()
{ 
Console.WriteLine("Автор …"); 
} 
Method1(); 



/*
---------------------------------------------------------------
-------------------Вторая группа методов ----------------------
---------------------------------------------------------------
*/
void Method2(string msg)
// где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы. 
{ 
Console.WriteLine(msg);
// оператор, в скобках указан принятый аргумент. 
} 
Method2("Текст сообщения");
// где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли. 

/*
Именованные аргументы 
Это когда у нас явно может быть указано какому аргументу, какое значение мы хотим указать. 
Это часто бывает нужно, если методы принимают какое-то количество аргументов, отличное от 1.
*/
void Method21(string msg, int count) 
{  
int i = 0; 
while (i < count) 
{ 
Console.WriteLine(msg);
// где переменная count отображает на экране определённое количество сообщений msg. 
i++; 
} 
} 
//Metod21("Текст", 4);
//метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4. 
Method21(msg: "Текст", count: 4); 
//Явно указывая наименование аргумента, не обязательно писать их по порядку
//Metod21 (count: 4, msg: "Текст"); 

/*
---------------------------------------------------------------
-------------------Третья группа методов-----------------------
---------------------------------------------------------------
Эти методы, которые что-то возвращают, но ничего не принимают. 
Если метод что-то возвращает, мы в обязательном порядке должны указать тип данных, значение которого ожидаем. 
*/

int Method3()
//не принимает никакие аргументы 
{  
return DateTime.Now.Year;
// обязательное использование оператора return, 
}  
int year = Method3();
//вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение 
Console.WriteLine(year); 

/*
---------------------------------------------------------------
-------------------Четвёртая группа методов -------------------
---------------------------------------------------------------
Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают
*/

string Method4(int count, string text) 
{ 
int i = 0; 
string result = String.Empty; 
while (i<count) 
{  
result = result + text; i++; 
}  
return result; 
}  
string res4 = Method4(10, "asdf"); 
Console.WriteLine(res4); 
/*
Возвращать будем строку string, по традиции называем метод Method4. Передавать будем int count и условный тип char, новый тип данных для вас. 
Соответственно, что мы здесь делаем? Мы будем string компоновать друг за другом count раз. 
Сделаем это. Для начала возьмем цикл, дальше нам потребуется переменная куда мы будем класть результат, конечный string result. 
Изначально можно и нужно в неё положит какое-то значение. 
Этим значением является пустая строка, чтобы не только вы понимали написанный код, более правильно, будет написать string.Empty. 
То есть таким образом мы можем просто прочитать, result у нас изначально будет пустой строкой. После этого используем конструкцию while. 
В которой пока i < count. Обязательно не забываем увеличивать счётчик и класть в result = result + text (это строчка, которую мы указали). 
Здесь, кстати в общем случае можно, например, правой кнопкой сделать rename и написать условный текст, тогда будет не только символ, но и текст.
Таким образом, у нас везде текст меняется, и соответственно, наименование аргумента будет изменяно. 
После того, как данный метод отработает, используем классический и известный оператор return, 
в котором указываем результат или переменную значение, которой ожидаем получить из метода. 
Чтобы вызвать этот метод мы должны будем, создать нужную нам переменную, дальше по порядочку указать, например, значение 10 и текст, 
который мы будем склеивать 10 раз, пусть это будет условный asdf текст. 
После этого можем показать на экране результат, который этот метод будет возвращать. 
*/


/*
---------------------------------------------------------------
-----------------------Цикл for--------------------------------
---------------------------------------------------------------
цикл со счётчиком или ещё называется цикл for. Синтаксически он просто в себе собирает все в кучу. 
Не нужно будет отдельно инициализировать счетчик, где-то в теле цикла что-то нужно будет увеличивать, где-то проверять условия. 
Цикл for как раз собирает всё в одном месте. 
*/

string Method41(int count, string text) 
{ 
    string result = String.Empty; 
    for (int i = 0; i<count; i++)
    //вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика). 
        {  
        result = result + text; 
        }  
    return result;  
}
string res41 = Method41(10, "asdf"); 
Console.WriteLine(res41); 

/*
---------------------------------------------------------------
-----------------------Цикл в цикле----------------------------
---------------------------------------------------------------
Классической демонстрацией использования циклов в цикле - это задача вывода таблицы умножения на экран. 
*/

for (int i = 2; i <= 10; i++) 
{  
    for (int j = 2; j <= 10; j++) 
    { 
        Console.WriteLine($"{i} * {j} = {i * j}");  
    } 
Console.WriteLine(); 
} 
/*
У нас есть цикл for, он очень легко строится. Дальше, мы указываем начальное значение. 
Таблица умножения начинается с 2. Затем говорим, что пока счётчик i меньше или равен 10, надо его увеличивать. 
После возьмём второй цикл, обратите внимание, что в первом (внешнем) цикле использовался счётчик i, значит, внутренний будет j, который мы также будем менять. 
Например, от 2 до меньше или равен 10. А телом второго цикла мы укажем непосредственное произведение. 
Сделать это можно различными способами. Используем интерполяцию строк: Console.WriteLine($"{i} * {j} = {i * j}");
Но есть проблема, связанная с тем, что вся таблица идёт без разделений на части. Исправим это путём добавления перехода на новую строку: Console.WriteLine(); 
*/


/*
---------------------------------------------------------------
-----------------------Работа с текстом -----------------------
---------------------------------------------------------------
Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" заменить большими "К", а большие "С" маленькими "с". Ясна ли задача? 

Первым делом, которым вы должны себе отметить. Это ясна ли вам задача? В частности: 
●	Что значит "Дан текст"? Как вы уже помните, из предыдущих лекций, дан – это непонятно. Ввёл пользователь? Считали из файла? Взяли с базы данных? Из какого-то 
сервиса может быть, скачали и так далее. Поэтому чётко определяем для себя, что 
значит, дан. В нашем случае мы будем считать, что он просто будет храниться как 
отдельная строка. 
●	Что значит "чёрточками"? Например, в русском языке мы можем сразу же выделить 
тире, дефис и ещё можно добавить минус. 
●	Какой алфавит у нас? Это может быть кириллица, в этом случае буква "к" одна. А 
может быть латиница, тогда буква "к" уже какой-то другой символом. При этом буквы "C" и "с" мало того что на одной кнопке находится, так ещё и выглядят одинаково. И 
хотя для нас они выглядят вроде бы одинаково, для компьютера это абсолютно разные символы. 
*/
/*
У нас есть сам текст:
— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля.
Вы так красноречивы. Вы дадите мне чаю?"
*/
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ " ежели бы вас послали вместо нашего милого Винценгероде,"
+ " вы бы взяли приступом согласие прусского короля."
+ " Вы так красноречивы. Вы дадите мне чаю?";
*/
/*
В нашем случае требуется небольшое пояснение, если будет какая-то строка, то для этой строки есть некоторое количество вспомогательного функционала. 
// string s = “qwerty” 
//             012345 
В частности, если требуется обратиться к конкретному символу строки, мы можем это делать, начиная отсчитывать позицию символов с 0. 
То есть «q» — это 0, «w» — 1, «e» — 2 и так далее. Чтобы получить конкретный символ, мы можем через квадратные скобки обратиться, указать идентификатор строки. 
Например: 
// s[3] // r 
В этом случае будьте, пожалуйста, внимательны нулевой символ «w» это 1 символ, дальше 2 символ это будет у нас 3. То есть, буква r будет именно s[3]. 
*/
/*
метод у нас будет принимать сроку и символы, которые нужно будет менять. Соответственно, старый символ и на который нужно будет заменить. 
Возвращаться точно так же будет строка, поэтому сразу можно сделать вывод о том, что это условно четвёртый вид методов. 
Назовём его Replace. Далее string и какой-то входной текст. Затем указываем конкретный символ oldValue и конкретный символ, на который мы будем менять, newValue. 
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace (string text, char oldValue, char newValue) 
{ 
    string result = String.Empty; 
    int length = text.Length;
    for (int i = 0; i < length; i++) 
        { 
        if(text[i] == oldValue) result = result + $"{newValue}"; 
        else result = result + $"{text[i]}";
        } 
    return result;
} 
string newText = Replace(text,' ','-'); 
Console.WriteLine(newText); 
Console.WriteLine(); 
newText = Replace(text,'к','К'); 
Console.WriteLine(newText);
newText = Replace(text,'с','С'); 
Console.WriteLine(newText); 


/*
------------------------------------------------------------------
-----------------------Упорядочить массивы -----------------------
------------------------------------------------------------------
Существуют разные алгоритмы, которые вы, скорее всего, будете писать в дальнейшем. Остановимся на одном из самых простых. 
Это так называемый алгоритм сортировки методом выбора, ещё его называют алгоритм сортировки методом минимакса 
или иногда просто называют методом максимального, или выбора максимального или выбора минимального и так далее. 
Узнаем, в чём особенность (суть) этого алгоритма. Есть какая-то последовательность чисел. 
Наша задача — выбрать самый первый элемент и в оставшейся части, с учётом нашей текущей позиции определить минимальный. 
После того как он найден, нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, 
это 6, с единицей, являющейся для нас минимальной, в общем, выделенном куске. 
Было: 6 8 3 2 1 4 5 7 
Стало: 1 8 3 2 6 4 5 7 
Поменяли. Дальше у нас следующий шаг, который будет выбирать очередной рабочий элемент для нас. 
Это теперь 8. Мы явно указываем то, что 1 уже отсортированы к ней больше касаться 
не нужно. Дальше наша задача во всём неотсортированном кусочке выбрать снова минимальный. Поменять его местами с рабочим.
Было: 1 8 3 2 6 4 5 7 
Стало: 1 2 3 8 6 4 5 7 
В таком случае получается подмассив или кусок массива из первых двух элементов отсортирован. 
Дальше переходим к следующему элементу, снова находим минимальный, и здесь получается так, что нам ничего ни с чем менять не нужно, 
то есть, он остаётся на своей позиции. На следующем этапе переходим к следующему рабочему элементу. Снова находим минимальный, 
снова меняем их местами, таким образом, мы продолжаем до того момента, пока весь массив не будет отсортирован. 
Результат: 1 2 3 4 5 6 7 8 
На самом деле мы сами указали достаточно много действий, но в то же время они могут быть выражены тремя пунктами. 
1. Найти позицию минимального элемента в неотсортированной части массива. 
2. Произвести обмен этого значения со значением первой неотсортированной позиции. 
3. Повторять пока есть неотсортированные элементы. 
*/

/*
1) Для начала заведём массив, который будем сортировать, 
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}. 
Для этого алгоритма абсолютно не принципиально, если внутри массива будут повторяющиеся элементы.

2) . На следующем этапе решим небольшую подзадачу, отвечающую за вывод данных массива на экран. Напишем отдельный метод. 
Причём сделаем это несколькими способами. Первый это метод void, назовём его PrintArray. В качестве аргумента будет приходить массив. 

3) Дальше. Получение, количество элементов (буду давать разные наименования, чтобы вы тоже потихонечку к этому привыкали) Length. 
Здесь цикл for, в котором мы пробегаем по всем элементам нашего массива. Показываем на экране. 
Можно это сделать так, чтобы вывод осуществлялся в одну строку. Напишем действие array[i] и через пробел будем указывать. 
После того как вывод окончен, выведем на экран пустую строку Console.WriteLine. 

4) Итак, PrintArray(arr), где PrintArray - это наименование нашего метода.
*/
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; 
void PrintArray(int[] array) 
{ 
    int count = array.Length;
    for (int i = 0; i < count; i++) 
        { 
        Console.Write($"{array[i]}"); 
        } 
    Console.WriteLine(); 
} 
PrintArray(arr);

/*
5) Следующий этап. Нам нужно написать метод, который будет упорядочивать наш массив. Назовём его selectionSort. 
В качестве аргумента точно таким же образом, как и в методе выше, будет приходить некий массив array. 

6) В первую очередь пробежаться по всем элементам нашего массива. Чтобы не нарушать общность, сделаем определение обращение к длине нашего массива через array.Length. 
Но здесь есть отдельная особенность, о которой мы чуть-чуть позже поговорим. 

7) На следующем этапе мы определяем позицию, на которую смотрим. Назовём её minPosition. 
И запоминаем позицию рабочего элемента, для которого мы в дальнейшем будем производить какие-то действия. 
Здесь, после того, как мы выполним, какой-то блок кода, нам потребуется поменять значение нашей минимальной позиции с найденной нами позицией.
Значит, int temporary = array. Наша рабочая оппозиция, напоминаю, что она будет вычисляться индексом i. 
Соответственно, в i позицию, мы должны будем положить элемент, который будет найден в процессе работы, 
этого пока не написанного кусочка кода. То есть, это простой обмен двух переменных местами. 
И соответственно, в эту минимальную позицию, мы кладём элемент, который был временным. 

8) Дальше наша задача — заполнить блок кода, всё, что мы здесь делаем, это ищем самый минимальный элемент. 
Как это будем делать? Мы воспользуемся циклом внутри цикла, как это было в самом начале лекции for j. 
Начальная позиция, от которой мы будем начинать эти действия, как вы помните, это кусочек массива, который был отсортирован, мы уже его не касаемся, 
а то, что нас отсортировано, начинается как раз с позиции i+1. И идём мы до последнего элемента array.Length. 

9) В этом блоке кода всё, что мы делаем — это ищем минимальный элемент. 
Чтобы это сделать, мы смотрим текущий, если он меньше того элемента, который мы предполагали на минимальной позиции, то нужно сохранить текущую позицию. 
Этот блок кода ищет максимальный элемент и здесь производится swap

10) Дальше самый важный пункт заключается в том, что если мы начинаем позицию поиска максимального от индекса i+1, 
где i меняется до максимального значения позиции нашего массива, то в этом случае мы должны будем искусственно одну единицу отнять. 
Тогда получится, что ровно это i+1 даст общее количество элементов. 

11) Вызвовем упорядочивание массива SelectionSort(arr).

*/

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) 
    { 
        int minPosition = i; 
        for (int j = i+1; j < array.Length; j++) 
        { 
            if(array[j] < array[minPosition]) minPosition = j; 
            { 
            minPosition = j;
            }  
        } 
    int temporary = array[i];
    array[i] = array[minPosition]; 
    array[minPosition] = temporary; 
    } 
}  
SelectionSort(arr); 
PrintArray(arr); 
