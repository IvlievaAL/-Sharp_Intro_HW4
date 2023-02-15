/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
System.Console.WriteLine("Enter N: ");
int N=int.Parse(Console.ReadLine());
int Ndigits=1;
int absnumber=Math.Abs(N);
int Ndivided=(absnumber/10);
int CountingDigitsinNumber (int N) //подзадача - посчитать количество цифр в числе
  {
for (; Ndivided>=1;Ndigits++)
   {
      Ndivided=Ndivided/10;
   }
  return Ndigits;
  }
int [] NumbertoMassive (int N) //подзадача - положить цифры числа в массив
  {
   CountingDigitsinNumber(N);
   int[] arrayN=new int[Ndigits];
Ndivided=Ndivided+(absnumber/10);
int Ndivided1=absnumber%10;
for (int index=Ndigits-1;index>=0;index=index-1)
   {
      arrayN[index]=Ndivided1;
      Ndivided1=Ndivided%10;
      Ndivided=Ndivided/10;
   }
 return arrayN;
  }
int SumofDigits(int N) //сама функция подсчета суммы цифр числа
 {
if (N==0)
{
  return 0;
}
else
{
 NumbertoMassive (N);
 int Sum=0;
 for (int index=0;index>N;index++)
   {
    Sum=Sum+NumbertoMassive (N)[index];
   }
   return Sum;
 }
  }
System.Console.WriteLine(SumofDigits(N));
