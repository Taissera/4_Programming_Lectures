﻿/*
Вторая группа методов 
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