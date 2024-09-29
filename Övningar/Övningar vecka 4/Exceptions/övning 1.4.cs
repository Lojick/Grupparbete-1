using System;
using System.Linq;
//Skapa en egen Exception klass och ärv alla Exception funktioner genom att skriva ": Exception".
public class ArrayTooSmallException : Exception
{
    //Skapa sedan en constructor med argumentet "message" och sedan anropa den till Exception klassen genom att skriva ":base(message)".
public ArrayTooSmallException(string message) :base(message)
{
}
}
class Programx
{
    static void Main(string[] args)
    {
    //Arrayen innehåller endast 9 element.
   int[] numbers = {1,2,3,4,5,6,7,8,9}; 
   //Vi testar att anropa funktionen med try och catch så inte programmet kraschar.
    try{ 
   Console.WriteLine(PrintArrays(numbers));
   }
   //Vi använder vår nya Exception klass som indikererar att värderna ej är giltiga enligt förväntning.
   catch(ArrayTooSmallException e){
   Console.WriteLine(e.Message);
   }
}
static int PrintArrays(int[]numbers){
    //Vi kollar om arrayens längd (element) är mindre än 10.
     if(numbers.Length < 10){
        //Vi refererar Exception till numbers så felet beskriver just numbers.
     throw new ArrayTooSmallException("Arrayen får ej innehålla negativa tal!"); 
   }

    return numbers.Sum();
}

}