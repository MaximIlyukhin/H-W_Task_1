//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Enter N = ");
int N = int.Parse(Console.ReadLine());
for(int i = 2; i<N-1; i+=2)         
    Console.Write(i + ", ");
if(N%2==0)
    Console.Write(N);
else
    Console.Write(N-1);
    
