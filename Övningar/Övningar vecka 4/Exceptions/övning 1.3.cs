// using System.Linq;
// class Program
// {
//     static void Main(string[] args)
//     {
//     //Arrayen innehåller endast 9 element.
//    int[] numbers = {1,-2,3,-4,5,6,7,8,9,10}; 
//    //Vi testar att anropa funktionen med try och catch så inte programmet kraschar.
//    try{ 
//    Console.WriteLine(PrintArrays(numbers));
//    }
//    //Vi använder ArgumentException som indikererar att värderna ej är giltiga enligt förväntning.
//    catch(ArgumentException e){
//    Console.WriteLine(e.Message);
//    }

// }
// static int PrintArrays(int[]numbers){
//     //Vi använder .Any() funktionen för att kontrollera varje element i arrayen.
//     // Vi använder samt lambda uttrycket för att kontrollera om det finns ett negativt tal.
//      if(numbers.Any(n => n < 0)){
//         //Vi refererar Exception till numbers så felet beskriver just numbers.
//       throw new ArgumentException(nameof(numbers), "Arrayen får ej innehålla negativa tal!"); 
//    }

//     return numbers.Sum();
// }

// }