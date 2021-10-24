// типы данных
// int - целочисленные
// double - дробные числа
// string - строки
// bool - Да/Нет
// char - один символ
// Сколько всего типов? ~20000 о.О
int a = 123, b=321;
// для присваивания значения используем = (то что справа присваивается влево)

//Console.Write("a: ");
//Console.WriteLine(a);
//Console.Write("b: ");
//Console.WriteLine(b);

Console.WriteLine("a: {a} b: {b}");
Console.WriteLine($"a: {a} b: {b}"); //++ интерполяция строк ++ (рекомендация Microsoft)
Console.WriteLine("a: {0} b: {1}",a,b); //
Console.WriteLine("a: " + a + " b: " + b); //конкатинация

Console.WriteLine(sizeof(int)*8);
Console.WriteLine("Ку-Ку");

//Поменять значения переменным местами
Console.WriteLine($"a: {a} b: {b}"); //a = 123, b=321;

//int c;
//c=b;
//b=a;
//a=c;

//a = a + b; 
//b = a - b; 
//a = a - b;

a = a + b - (b = a);

Console.WriteLine($"a: {a} b: {b}"); //a = 321, b=123;


if (a>b) //условие
{
    Console.WriteLine(a); //если условие истина
}
else //иначе
{
    Console.WriteLine(b); //если условие ложно
}

int max;
if (a>b) //условие
{
    max=a; //если условие истина
}
else //иначе
{
    max=b; //если условие ложно
}
Console.WriteLine(max);

int count = 1;
while (count <= 10)
{
    Console.WriteLine(count);
    //count = count + 1;
    //count += 1;
    count++;
}

//подсчитайте количество чисел, которые делятся на 3 и на 5
//из [2,128]
int number = 21;
bool flag1 = (number%3) == 0;
bool flag2 = (number%5) == 0; 
bool result = flag1 && flag2;
Console.WriteLine(flag1);
Console.WriteLine(flag2);
Console.WriteLine(result);

int start = 2, end = 128;
int i = start;
count = 0;
while (i <= end)
{
    if ((i%3==0) && (i%5==0))
    {
        count++;
        Console.Write($"{i}:");
    }
    i++;
}
Console.WriteLine($"count={count}");
