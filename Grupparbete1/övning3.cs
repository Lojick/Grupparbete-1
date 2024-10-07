// using System.IO;
// //Uppgift 3
// class Program
// {
//     static void Main(string[] args)
//     {  //Ignorera dem 2 raderna underst, jag har redan skapat en fil.
//         // string writeText = "Hello, world!";
//         // File.WriteAllText("filename.txt", writeText); 

//          //Be användaren skriva filnamn.
//         Console.WriteLine("Skriv in filnamnet.");
//         string fileName = Console.ReadLine();
//         //För att testa och inte få programmt krascha, så anvnänder vi en try och catch.
//         try{
//             //Använd funktionen ReadAllText för att söka igenom om filen finns

//             string readText = File.ReadAllText(fileName);
//             //Samt anropa funktionen.
//             PrintInfo(readText);
//         }
//         //Vi använder denna exception för filer som ej  kan hittas.
//         catch(FileNotFoundException){
//             Console.WriteLine("Filen hittades ej!");
//         }
//     }
//     //Skapa metoden för att printa ut innehållet.
//     static void PrintInfo(string readText){
//         Console.WriteLine("Innehållet är " + readText);
//     }
// }

