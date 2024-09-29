// class Program
// {
//     static void Main(string[] args)
//     {
//     //Arrayen innehåller endast 9 element.
//    int[] numbers = {1,2,3,4,5,6,7,8,9}; 
//    //Vi testar att anropa funktionen med try och catch så inte programmet kraschar.
//    try{ 
//    Console.WriteLine(PrintArrays(numbers));
//    }
//    //Vi använder ArgumentOutOfRangeException som indikererar att storleken på argumenetet är utanför det förväntade.
//    catch(ArgumentOutOfRangeException e){
//    Console.WriteLine(e.Message);
//    }

// }
// static int PrintArrays(int[]numbers){
//     //Vi kollar om arrayens längd (element) är mindre än 10.
//      if(numbers.Length < 10){
//         //Vi refererar Exception till numbers så felet beskriver just numbers.
//       throw new ArgumentOutOfRangeException(nameof(numbers), "Arrayen är mindre än 10!"); 
//    }

//     return numbers.Sum();
// }

// }