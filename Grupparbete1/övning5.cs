using System;
class Program
{
    static void Main(string[] args)
    {   //Skriv ner alla strängar.
        string a = "Hej, jag gillar glass. Vad gillar du?";
        string b = "Jag brukar programmera. Är du en programmerare också?";
        string c = "Du måste handla mat medans jag städar huset.";
        //Skriv ut varsin string via terminalen.
        Console.WriteLine(SwapWords(a));
        Console.WriteLine(SwapWords(b));
        Console.WriteLine(SwapWords(c));
    }
     //Skapa funktionen som tar in alla strängar i en input parameter.
    static string SwapWords(string input){
//Eftersom jag vill den ska skriva ut i samma format, byter jag även stora "jag" och "du".
//Jag använder TEMP1 och TEMP2 för att den ska byta plats på dem och inte ersätta helt. 
// Det är endast temporärt, så jag byter tillbaka så ombytet sker korrekt.
 string temp = input.Replace("jag", "TEMP1").Replace("Jag", "TEMP2");
        temp = temp.Replace("du", "jag").Replace("Du", "Jag");
        temp = temp.Replace("TEMP1", "du").Replace("TEMP2", "Du");

        return temp;
    
    }
}
// Enklaste alternativet, men då kommer alla "jag" och "du" skrivas ut i små bokstäver.
//    return input.Replace("jag", "temp", StringComparison.OrdinalIgnoreCase)
//                     .Replace("du", "jag", StringComparison.OrdinalIgnoreCase)
//                     .Replace("temp", "du", StringComparison.OrdinalIgnoreCase);