Console.Clear();
Console.WriteLine("Введите  число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void EnumerationNumber(int number)
{
   if (number == 0) return;

   Console.Write($"{number}");
   EnumerationNumber(number - 1);
}

EnumerationNumber(numberN);