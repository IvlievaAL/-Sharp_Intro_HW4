/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

void PrintMassiveOf8RandomNumbers()
{
 int [] ArrayOf8Numbers= new int [8];
 Random rand=new Random();
 for (int index=0; index<8; index++)
 {
    ArrayOf8Numbers[index]=rand.Next();
    System.Console.WriteLine (ArrayOf8Numbers[index]);
 }
}
PrintMassiveOf8RandomNumbers();