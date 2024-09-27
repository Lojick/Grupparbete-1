// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Ange en sträng:");
//         string input = Console.ReadLine();

//         string reversed = ReverseString(input);

//         if (input == reversed)
//         {
//             Console.WriteLine("Strängen är en palindrom.");
//         }
//         else
//         {
//             Console.WriteLine("Strängen är inte en palindrom.");
//         }
//     }

//     static string ReverseString(string str)
//     {
//         char[] charArray = str.ToCharArray();
//         Array.Reverse(charArray);
//         return new string(charArray);
//     }
// }
