 using System;
using System.Linq;
using System.IO;
 class Program
  {
  //Skapa en funktion som tar in arrays och räknar ut största och minsta talet.
  static string PrintInfo(int[] numbers){

int largestNumber = numbers.Max();
int smallestNumber = numbers.Min();
//Returnera och skriv ut.
return $"Det största numret är {largestNumber} och det minsta numret är {smallestNumber}";
  }
 
static void Main(string[] args)
{
//Sätt upp valfria talen i en array.
int [] numbers = {1,3,5};
//Skriv ut arrayen på konsollen.
Console.WriteLine(PrintInfo(numbers));
}
  }