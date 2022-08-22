

Console.Clear();
Console.WriteLine("Задайте значения M и N. Программа, которая находит сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите  число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = 0;

void SumElements(int numberOne, int numberTwo)
{

   if (numberOne > numberTwo) return;

   if (numberOne <= numberTwo)
   {

      sum += numberOne;
      SumElements(numberOne + 1, numberTwo);


   }
   if (numberOne == numberTwo)
   {
      Console.WriteLine(sum);
   }


}

SumElements(numberM, numberN);