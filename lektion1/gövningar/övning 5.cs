// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Skriv in inputen och börja att anta summan är noll från början.
//         string input = "5hej1jag34heter8ironman";
//         int sum = 0;
//         //Vi använder variabeln c och datatypen char för att hitta tecken i string input.
//         foreach (char c in input)
//         {
//             //Vi använder IsDigit funktionen för att kontrollera om det finns tecken i c variabeln.
//             if (char.IsDigit(c))
//             {
//                 // Sen lägger vi till det nya talet med det nuvarande summan.
//                 sum += int.Parse(c.ToString());
//             }
//         }
//                 // Resultatet presenteras.
//         Console.WriteLine("Summan av alla siffror i strängen är: " + sum);
//     }
// }
