// See https://aka.ms/new-console-template for more information
// Задание 1

Console.WriteLine("Вывод while(false)");
while (false){
    Console.WriteLine("что-то от while");
}

Console.WriteLine("Вывод do while(false)");
do{
    Console.WriteLine("что-то от do while");
}
while (false);

Console.WriteLine("последовательность 2^n от 0 до выбранного числа");
int i = int.Parse(Console.ReadLine());
int j = 1;
while (j < i){
    Console.WriteLine(j);
    j *= 2;
}


Console.WriteLine("Ряд Фибоначчи:");
long num = long.Parse(Console.ReadLine());

long a = 0;
long b = 1;
long k = 0;

while (k < num)
{
    Console.WriteLine(a);
    long c = a + b;
    a = b;
    b = c;

    k++;
}
