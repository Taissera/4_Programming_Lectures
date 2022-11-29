﻿/*
Цикл for
цикл со счётчиком или ещё называется цикл for. Синтаксически он просто в себе собирает все в кучу. 
Не нужно будет отдельно инициализировать счетчик, где-то в теле цикла что-то нужно будет увеличивать, где-то проверять условия. 
Цикл for как раз собирает всё в одном месте. 
*/

string Method4(int count, string text) 
{ 
    string result = String.Empty; 
    for (int i = 0; i<count; i++)
    //вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика). 
        {  
        result = result + text; 
        }  
    return result;  
}
string res = Method4(10, "asdf"); 
Console.WriteLine(res); 