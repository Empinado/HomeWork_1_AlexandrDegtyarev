// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4

Console.Write ("Ввести число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N>0)
for (int i = 2; i<N+1; i=i+2)
{
    Console.WriteLine(i);
}
else
for(int i = 0; i>N-1; i=i-2)
{
    Console.WriteLine(i);
}