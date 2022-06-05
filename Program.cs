// Программа про собаку и двух друзей
Console.WriteLine("Hello, World!");

int count = 0;
float dist = 10000;
int speed1 = 1;
int speed2 = 2;
int dogspeed = 5;
int friend = 1;
int time1;
while (dist > 10)
{
    if (friend == 1)
    {
        time1 = dist / (speed1 + dogspeed);
        friend = 2;
    }
    else
    {
        time1 = dist / (speed2 + dogspeed);
        friend = 1;
    }
    dist = dist - (speed1 + speed2) * time1;
    count += 1;
}
Console.WriteLine("Dog will run " + count + " times!");

// задача №1
/* Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
*/
Console.WriteLine("Задача №1 - Определение максимума и минимума из двух чисел");
Console.WriteLine("Введите целое число №1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число №2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Максимальное число = " + num1);
    Console.WriteLine("Минимальное число = " + num2);
}
else 
{
    if (num1 == num2)
         {
            Console.WriteLine("Числа равны");
         }
         else 
         {
            Console.WriteLine("Максимальное число = " + num2);
            Console.WriteLine("Минимальное число = " + num1);   
         }
}
 

// задача №2
/* Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Задача №2 - Определение максимума из трех чисел.");
Console.WriteLine("Введите целое число №1: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число №2: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число №3: ");
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2 & num1 > num3)
{
    Console.WriteLine("Максимальное число из трех = " + num1);
}
else
{
    if (num2 > num1 & num2 > num3)
    {
        Console.WriteLine("Максимальное число из трех = " + num2);
    }
    else
    {
        Console.WriteLine("Максимальное число из трех = " + num3);
    }
}


// Задача №3
/* Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка). */

Console.WriteLine("Задача №3 - Определение числа на четность");
Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
if (num%2 == 0)
{
    Console.WriteLine("Число " + num + " - чётное");
}
else
{
    Console.WriteLine("Число " + num + " - нечётное");
}


// Задача №4
/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
 */

Console.WriteLine("Задача №4 - Вывод четных чисел до заданного числа");
Console.WriteLine("Введите целое положительное число: ");
num = int.Parse(Console.ReadLine());
int index = 0;
while (index < num)
{
    Console.Write(index +  " ");
    index +=2;
}
Console.WriteLine("\nКонец! \n");
