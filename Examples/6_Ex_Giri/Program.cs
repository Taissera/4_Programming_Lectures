// В нашем примере с гирями фигурировали конкрертные числа, пропишем их
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
// определим переменную max, в которую кладём значение первой гири
int max = a;
// далее пропишем набор условий
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;
Console.Write("max = ");
Console.Write(max);