/*
Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ack(int m,int n)
{
int ans;
 if  (m == 0 ) ans = n+1;
 else if (n == 0) ans = ack(m-1,1);
 else ans = ack(m -1, ack(m,n-1));
 return (ans);

} 
Console.WriteLine(ack(4,1));
