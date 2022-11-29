﻿/*
Четвёртая группа методов 

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
string res = Method4(10, "asdf"); 
Console.WriteLine(res); 

/*
Возвращать будем строку string, по традиции называем метод Method4. 
Передавать будем int count и условный тип char, новый тип данных для вас. 
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