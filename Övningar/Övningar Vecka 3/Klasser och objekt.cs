
// //ÖVNING 1-5
// public class Person //Skapa en ny klass med namnet Person.
// {
//     string name;  //Lägg till fält för namn och ålder med string och int datatyper.
//     int age;
    
//     public Person(string name, int age ) //Lägg till en konstruktor för namn och ålder.
//     {
//         this.name = name; //Sätt värdet på name.
//         this.age = age;   //Sätt värdet på age.
//     }
//     public void PrintInfo() // Skapa en funktion som vi använder senare för att anropa och skriva ut.
//     {
//          //Skriv ut resultatet och använd this.name och age för att inte förväxla med andra name och age.
//       Console.WriteLine("Namn: " + this.name + ", Ålder: " + this.age);

//     }
//     public class Program
//     {
//     static void Main(string[] args)
//     {
//         //Skapa ny Person-objekt och lägg in valfria värden på name och age.
//       Person person = new Person("Lorik Azemi", 28);
//       person.PrintInfo();
    
//     }
// }
// }
// ÖVNING 5-6
// using System;
// using System.Net.Http.Headers;
// public class Maträtter
// {
//     string name;
//     public Maträtter(string name)
//     {
//     this.name = name;
//     }
//     public string PrintInfo() //Om den ska returnera en sträng måste du lägga till string.
//     {
//         return name;
//     }
//     public class Program
//     {
//     static void Main(string[] args)
//     {
//     Maträtter maträtter1 = new Maträtter("Kebabpizza");
//     Maträtter maträtter2 = new Maträtter("Hamburgare"); 
//     Maträtter maträtter3 = new Maträtter("Chicken korma");
//  Console.WriteLine("Mina favoritmaträtter är " + maträtter1.PrintInfo() + " ," + maträtter2.PrintInfo() + " och " + maträtter3.PrintInfo());
//     //Anropa funktionen och samtidigt skriv ut.
//     //Jag skrev på detta sättet eftersom jag ville ha allt utskrivet
//      }
//   }
// }
//Övning 7-8
// public class Filmer
// {
//     string name;

// public Filmer(string name)
// {
//     this.name = name;
// }
// public string PrintInfo()
// {
// return name;
// }
// }
// public class Program
// {
//     static void Main(string[] args)
//     {
//     Filmer filmer1 = new Filmer("Avengers: End game");
//     Filmer filmer2 = new Filmer ("Interstellar");
//     Filmer filmer3 = new Filmer ("Shawshank Redemption");

//     Console.WriteLine("Mina favoritfilmer är: " + filmer1.PrintInfo() + " , " + filmer2.PrintInfo() + " och " + filmer3.PrintInfo());
// }
// }

//Övning 9-10
// public class Bilar{
//     string model;
//     int year;
// public Bilar(string model, int year)
// {
//     this.model = model;
//     this.year = year;
// }
// public override string ToString()
// //Vi använder ToString  metoden för att returnera både model och year i samma sträng
// // För att självklart också slippa skriva massa onödiga koder.
// {
//     return model + " (" + year + ")"; // Använd "("+variabel+")" för att skapa parantes.
// } 
// }

// public class program
//     {
//     static void Main(string[] args)
//     {
//     Bilar bilar1 = new Bilar("Honda Civic" , 2018);
//     Bilar bilar2 = new Bilar("Volvo V60" , 2018);
//     Bilar bilar3 = new Bilar("Porsche Panamera" , 2024);
//     Console.WriteLine("Mina favoritbilar är: " + bilar1 + " , " + bilar2 + " och " + bilar3); 
                                                
    
//     }
// }
