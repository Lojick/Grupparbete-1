
using System;
using System.Linq;
using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {
//         myFunction("Lorik", 28);
//         myFunction("Iron Man", 50);
//     }
//     static void myFunction(string name, int age)
// {
//  Console.WriteLine(name + " is " + age + " years old.");
// }

// }


// class Program
// {
//     static void Main(string[] args)
//     {
//     Console.WriteLine(myFunction(5,5));
//     }
//     static int myFunction(int x, int y)
// {
//     return x + y;
// }

// }


// class Program
// {
//     static void Main(string[] args)
//     {
//     myFunction("Honda", "Civic", 2018);
//     }
//     static void myFunction(string car, string model, int year)
// {
// Console.WriteLine(car + " " + model + " " + year);
// }

// }
// class Program
// {
//     static void Main(string[] args)
//     {
//     int sum = myFunction(5,5);
//     Console.WriteLine(sum);
//     }
//     static int myFunction(int a, int b)
// {
// return a*b;
// }

// }

// class Program
// {
//     static void Main(string[] args)
//     {
//     Console.WriteLine(myFunction(5,5));
//     }
//     static int myFunction(int a, int b)
// {
// return a*b;
// }

// }

// class Program
// {
//     static void Main(string[] args)
//     {
//     myFunction("Sweden", "Ulf Kristersson");
    
//     }
//     static void myFunction(string country, string president)
// {
// Console.WriteLine(country + "'s prime minister is " + president);
// }

// }
//  class Car{
//     public string name;
//     public int number;
// public Car(string model, int year)
// {
//     this.name = model;
//     this.number = year;
// }

// public void PrintInfo(){ //Om du ska komma åt en instans måste du ha public och inte sttic.
//  Console.WriteLine(this.name + " " + this.number);
// }
// } //Glöm ej att ha den inom samma klass som Car.
// class Program
// {
//     static void Main(string[] args)
//     {
//    Car car1 = new Car("Honda Civic", 2018);
//    car1.PrintInfo(); //Om du ska komma åt en instans måste du referera till den.
// }

// }
//  class Car{
//     public string name;
//     public int number;
// public Car(string model, int year)
// {
//     this.name = model;
//     this.number = year;
// }

// public string PrintName(){
//     return name;
// }                                //Skapa olika metoder för att returnera namn och nummer.
// public int PrintNumber(){
//     return number;
// }
// } //Glöm ej att ha den inom samma klass som Car.
// class Program
// {
//     static void Main(string[] args)
//     {
//    Car car1 = new Car("Honda Civic", 2018);
//    Console.WriteLine(car1.PrintName() + " " + car1.PrintNumber()); //Anropa på objektet och returnera.
// }

// }

//  class Car{
//     public string name;
//     public int number;
// public Car(string model, int year)
// {
//     this.name = model;
//     this.number = year;
// }

// public string Printinfo(){
//     return name + " " + number; //Om du vill returnera båda så måste du returnera båda i en sträng.
// }                         
// } //Glöm ej att ha den inom samma klass som Car.
// class Program
// {
//     static void Main(string[] args)
//     {
//    Car car1 = new Car("Honda Civic", 2018);
//    Console.WriteLine(car1.Printinfo());
   
// }
// }

// }

// public class Person{
//     public string name;
//     public int age;
//     public Person(string name, int age){
//         this.name = name;
//         this.age = age;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//    Person human = new Person("Lorik", 28);
//    Person human2 = new Person("Rashad", 27);
//    Person human3 = new Person("Abbas", 28);
//    Person human4 = new Person("Ahmed", 27);
//    Person human5 = new Person("David", 28);

//    Person[]arrayPerson = {
//     new Person("Lorik", 28);
//     new Person("Rashad", 27);
//     new Person("Abbas", 28);
//     new Person("Ahmed", 27);
//     new Person("David", 28);
//    };
//    foreach(Person persons in arrayPerson){
//     Console.WriteLine(persons);
//    }



   
// }

// }
// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     static string MyMethod(int [] numbers)
//     {
//      return numbers.Max() + " " +  numbers.Min();
//     }

//     static void Main(string[] args)
//     {
//       int [] numbers = {1,3,5};
//       Console.WriteLine(MyMethod(numbers));

//     }
//   }
// }
// class Person
// {
//     public string Name { get; } // Read-only property

//     // Konstruktor som sätter värdet
//     public Person(string name)
//     {
//         Name = name;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person person = new Person("Anna");
//         person.Name = "Lisa";
//         Console.WriteLine(person.Name);  // Kan läsas
//         // person.Name = "Lisa";  // Ger fel, kan inte ändra värdet
//     }
// }

// string writeText = "Hello, world!";
// File.WriteAllText("test.txt", writeText);
// string readText = File.ReadAllText("test.txt");
// Console.WriteLine(readText);

//  class Cars{
//     public string model;
//     public string color;
//     public int year;
//     public Cars(string model, string color, int year){
//         this.model = model;
//         this.color = color;
//         this.year = year;
//     }

// }

// enum Days{
//     Måndag,
//     Tisdag ,
//     Onsdag,
//     Torsdag,
//     Fredag,
//     Lördag,
//     Söndag,
// }

//         class Program
//   {

// static void Main(string[] args)
// {
  
//       int age = 16;
//         if(age < 18){
//         throw new Exception("För ung!");
//         }
//         else{
//           Console.WriteLine("Gammal nog!");
//         }

// }
//   }


//         class Program
//   {

// static void Main(string[] args)
// {
//   try{

//   int[] nums = {1,2,3,4};
// Console.WriteLine(nums[5]);
//   }
//   catch(Exception e){
//     Console.WriteLine("Den finns inte!");
//   }
// }

// }

