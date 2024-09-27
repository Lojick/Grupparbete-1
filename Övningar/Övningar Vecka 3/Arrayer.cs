
// using System;
// using System.Linq;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //ÖVNING 5.1
// int[] numbers = {3,5,8,6,2};   //Börja sätta upp alla arrays i en loop.
// foreach(int i in numbers){

//     Console.WriteLine(i); //Skriv ut.
// }
// int largest = numbers[0]; //Vi börjar anta att största talet är 3 , som vi sedan kan jämföra med resten.
// foreach(int num in numbers) //
// {
//     if(num>largest)
// //num betyder alla element i arrayen, så 3:an börjar jämföra med 3:an(largest), tills den hittar något som är större och uppdaterar.
// // T.ex. largest = 5 , sen largest = 8 och den stannar på 8an för att 8an är störst.    
//     {
//         largest = num; //Sedan uppdaterar vi largest värdet i num.
//     }
    
// }
// Console.WriteLine("Största talet är " + largest);  //Skriv ut resultatet.
// }

// }
// Övning 5.2
// using System;
// using System.Linq;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //ÖVNING 1
// int[] numbers = {3,5,8,6,2};   //Börja sätta upp alla arrays i en loop.
// foreach(int i in numbers){

//     Console.WriteLine(i); //Skriv ut.
// }
// int smallest = numbers[0]; //Vi börjar anta att minsta talet är 3 , som vi sedan kan jämföra med resten.
// foreach(int num in numbers) //
// {
//     if(smallest > num)
// // Samma princip här, fast tvärtom. Nu jämför vi om smallest (3:an) är mindre än resten, och den kommer vara det fram tills vi kommer till 2.  
//     {
//         smallest = num; //Sedan uppdaterar vi smallest värdet i num.
//     }
    
// }
// Console.WriteLine("Minsta talet är " + smallest);  //Skriv ut resultatet.
// }

// }

//Övning 5.3
// using System;
// using System.Linq;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //ÖVNING 1
// int[] numbers = {3,5,8,6,2};   //Börja sätta upp alla arrays i en loop.
// foreach(int i in numbers){
//     Console.WriteLine(i); //Skriv ut.
// }
// int sum = 0; //Vi börjar anta summan är noll först. Se nedan för mer förklaring.
// foreach(int num in numbers){
// sum += num;
// //Om vi plusar varje element med 0, så kommer vi få fram i stort sett en summa.
// // T.ex. 0+3+5+8+6+2.
// }
// double medelvärde = (double)sum/5; 
// //Vi överför sum (int) till double med hjälp av en parantes och dela den med 5.
// Console.WriteLine(medelvärde); //Skriv

// }
// }

// //Övning 5.4
// using System;
// using System.Linq;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //ÖVNING 1
// int[] numbers = {3,5,8,6,2};   //Börja sätta upp alla arrays i en loop.
// foreach(int i in numbers){
//     Console.WriteLine(i); //Skriv ut.
// }
// int sum = 0; //Vi börjar anta summan är noll först. Se nedan för mer förklaring.
// foreach(int num in numbers){
// sum += num;
// Console.WriteLine(sum);
// //Om vi plusar varje element med 0, så kommer vi få fram i stort sett en summa.
// // T.ex. 0+3+5+8+6+2.
// }

// }
// }

// Övning 6
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

//    Person[]humanArray = { //Skapa en array av dina klass-objekter.
//     new Person("Lorik", 28),
//     new Person("Rashad", 27),
//     new Person("Abbas", 28),  //Lägg ihop allt.
//     new Person("Ahmed", 27),
//     new Person("David", 28),
//    };
//     int sum = 0; //Anta summan börjar på noll.
//    foreach(Person i in humanArray){
//     sum += i.age; 
//     //Lägg till noll med resten så det blir en summa.
//     Console.WriteLine(sum); //Skriv ut
//    }

// }

// }

