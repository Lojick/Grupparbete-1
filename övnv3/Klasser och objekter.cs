public class Film{
    public string name;
    public int number;
  public Film(string title, int year)
    {
        this.name = title;
        this.number = year;
    }
}
//     class Program
// {
//     static void Main(string[] args)
//     {
        Film favoritFilmer = new Film("Interstellar", 2014);
        Film favoritFilmer2 = new Film("Avengers: Endgame", 2018);
        Film favoritFilmer3 = new Film("Shawshank Redemption", 1994);
//         Console.WriteLine(favoritFilmer.name + " " +favoritFilmer.number);
//         Console.WriteLine(favoritFilmer2.name + " " +favoritFilmer2.number);
//         Console.WriteLine(favoritFilmer3.name + " " +favoritFilmer3.number);
//     }
// }
