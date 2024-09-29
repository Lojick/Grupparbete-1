// class Program
// {
//     static void Main(string[] args)
//     {
//     //Arrayen är null eftersom variabeln ej har ett värde.
//    int[] numbers = null; 
//    //Vi testar att anropa funktionen med try och catch så inte programmet kraschar.
//    try{ 
//    Console.WriteLine(PrintArrays(numbers));
//    }
//    //Vi använder ArgumentNullException som är lämpligt för detta felet.
//    catch(ArgumentNullException e){
//    Console.WriteLine(e.Message);
//    }

// }
// static int PrintArrays(int[]numbers){
//     //Vi kollar om arrayen är null, så kastar vi ArgumentNullException.
//      if(numbers == null){
//         //Vi refererar den till numbers så felet beskriver just numbers.
//       throw new ArgumentNullException(nameof(numbers), "Arrayen får inte vara null."); 
//    }

//     return numbers.Sum();
// }

// }