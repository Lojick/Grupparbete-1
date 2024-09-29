class Program
{
    static void Main(string[] args)
    {
        //Ta in en sträng från terminalen.
        Console.WriteLine("Skriv in en sträng.");
        //Läs av input.
        string input = Console.ReadLine();
        //För att omvandla den baklänges, måste man först omvandla den till en char array.
        // Vi använder funktionen ToCharArray() för det.
        char[] inputArray = input.ToCharArray();
        //Slutligen använd funktionen Array.Reverse att omvandla den baklänges.
        Array.Reverse(inputArray);
        //Skriv ut resultatet och omvandla tillbaka den till en sträng.
        Console.WriteLine(new string (inputArray));
    }
}