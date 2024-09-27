class Program
{
    static void Main(string[] args)
    {
        string input = "Hej, jag gillar glass. Vad gillar du?";

        Console.WriteLine(SwapWords(input));
    }
    static string SwapWords(string input){
        string newInput = input.Replace("jag", "du");
        return newInput;
    
    }
}
