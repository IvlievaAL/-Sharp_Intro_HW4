/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
System.Console.WriteLine("Enter N: ");
int N=int.Parse(Console.ReadLine());
int NumberofDigits(int number)
 {
if (number==0)
{
  return 1;
}
else
{
int absnumber=Math.Abs(number);
int Ndigits=1;
int Ndivided=(absnumber/10);
for (; Ndivided>=1;Ndigits++)
   {
      Ndivided=Ndivided/10;
   }
int[] arrayN=new int[Ndigits];
Ndivided=Ndivided+(absnumber/10);
int Ndivided1=absnumber%10;
for (int index=Ndigits-1;index>=0;index=index-1)
   {
      arrayN[index]=Ndivided1;
      Ndivided1=Ndivided%10;
      Ndivided=Ndivided/10;
   }
 return arrayN[Ndigits-1];
}
  }
System.Console.WriteLine(NumberofDigits(number));
