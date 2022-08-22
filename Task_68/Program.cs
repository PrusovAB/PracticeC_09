Console.Clear();
Console.WriteLine("Программа  функция Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.Write("Введите  число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());




int FunctionAkkerman(int n, int m)
{

   if (n == 0) return m + 1;
   if (n != 0 && m == 0) return FunctionAkkerman(n - 1, 1);
   if (n > 0 && m > 0) return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
   return FunctionAkkerman(n, m);
}

int fAkkerman = FunctionAkkerman(numberM, numberN);
Console.WriteLine(fAkkerman);