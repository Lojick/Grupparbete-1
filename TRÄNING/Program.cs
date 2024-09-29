using System.IO;

// class Program
// {
//     enum Dagar{
//         Måndag,
//         Tisdag,
//         Onsdag,
//         Torsdag,
//         Fredag,
//         Lördag,
//         Söndag,
//     }
//     static void Main(string[] args)
//     {
//         Dagar myDays = Dagar.Måndag;
//         Console.WriteLine(myDays);
//     }
// }


// class Program
// {
//     enum Positioner{
//         VD,
//         Revisor,
//         Assistent,
//         Rekryterare,
//         Utvecklare,
//     }
//     static void Main(string[] args)
//     {
//         Positioner myPositions = Positioner.VD;
//         Console.WriteLine(myPositions);
//     }
// }

// class Program
// {
//     enum Mat{
//         Indisk,
//         Italiensk,
//         Amerikansk,
//         Grekisk,
//         Arabisk,
//     }
//     static void Main(string[] args)
//     {
//         int myNum = (int)Mat.Grekisk;
//     //Överför Mat.Grekisk till int format så du kan se värdet.

//         Console.WriteLine(myNum);
//     }
// }

// class Program
// {
//     enum DifficultyLevel{
//         Easy = 1 ,
//         Medium = 2,
//         Hard = 3,
    

//     }
//     public static void PrintInfo(int ){
//         Console.WriteLine(myLevel);
//     }
//     static void Main(string[] args)
//     {
//     int myLevel = (int)DifficultyLevel.Easy;
//     PrintInfo();
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        try{
     string writeText = "Hello, world!";
        File.WriteAllText (":\\InvalidPath\\filename.txt", writeText);
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        try{
     string readText = File.ReadAllText("filename.txt");
     Console.WriteLine(readText);
       
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }

    }
}
