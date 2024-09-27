using System;
using System.Linq;
class Program
{
    //EXCEPTIONS Övning 1
    static void Main(string[] args)
    {
   int[] numbers = {1,3,5,7};
   Console.WriteLine(PrintArrays(numbers));
  

}
static int PrintArrays(int[]numbers){

    return numbers.Sum();
}

}