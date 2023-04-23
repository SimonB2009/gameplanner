using System;
using System.Net;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Softplanner
{  
   [Serializable()]
   public class Proj 
   {
      public string name;
      public string typ;
      public string github;
      public string programmer;
      public string discription;
      public string fromto;
      public string language;
      public Proj(string name, string typ, string github, string programmer, string discription, string fromto, string language) {
         this.name = name;
         this.typ = typ;
         this.github = github;
         this.programmer = programmer;
         this.discription = discription;
         this.fromto = fromto;
         this.language = language;

      }
   }        
   
   
   public class Softplanner {

         static string action = "";
         static bool restart = false;
         static string command = "";
         static string givename = "";
         static bool showrestart = false;
         public static List<Proj> projects = new List<Proj> {};
         static void Main(string[] args) {
            load();
            start();
            save();
         }

         static void start() {
            if(restart == false) {
               for (int i = 0; i < 100; i++) {
                  Console.WriteLine("");
               }

               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("  -------------------------- Start -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
            }
           
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("      Action (show / new / leave) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            action = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.Write("      Action =  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(action);
            
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Are you sure (yes / no) : ");
            Console.ForegroundColor = ConsoleColor.Blue;

            if (Console.ReadLine() == "yes") {

               if (action == "leave") {
                  Environment.Exit(0);
               }

               if (action == "show") {
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("  -------------------------- Show -----------------------------");
                  Console.ForegroundColor = ConsoleColor.White; 
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;

                  showrestart = false;
            
                  show();
               } else { //create
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("  -------------------------- Create -----------------------------");
                  Console.ForegroundColor = ConsoleColor.White; 
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;

                  create();
               }

            } else {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("  -------------------------- Restart -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
               restart = true;
               start();
            }

         }

         static void show() {
            if(showrestart == false) {
               Console.ForegroundColor = ConsoleColor.Magenta;
               Console.WriteLine("      Commands:");
               Console.ForegroundColor = ConsoleColor.Magenta;
               Console.WriteLine("      give <name> = give the project by name");
               Console.WriteLine("      give -A = give all projects");
               Console.WriteLine("      give <first letter> = give all projects with this first letter");
               Console.WriteLine("      give <any letter/-s> = give all projects with this letter/-s");
               Console.WriteLine("      leave = leave show");
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      ⟫ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            if (Console.ReadKey().Key == ConsoleKey.G) {
               if (Console.ReadKey().Key == ConsoleKey.I) if (Console.ReadKey().Key == ConsoleKey.V) if (Console.ReadKey().Key == ConsoleKey.E) {
                  Console.ForegroundColor = ConsoleColor.White;
                  givename = Console.ReadLine();
                  if (givename == " -A") {
                     giveall();
                     showrestart = true;
                     show();
                  } else {
                     givebyname(givename.Trim());
                     showrestart = true;
                     show();
                  }
               }
            } else {
               command = Console.ReadLine();

               if (command == "eave") {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("  -------------------------- Leaving Show -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
               restart = true;
               start();
               } else {
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("      ERROR - This Comand doesn t exist");
               Console.WriteLine("");
               Console.WriteLine("");
               show();
               }
            }

         }

         static void givebyname(string name) {
            foreach (Proj p in projects) {
               if (p.name.IndexOf(name)  != -1) {
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.Write("      " + p.name + " :");
                  Console.ForegroundColor = ConsoleColor.White;
                  Console.Write("   " + p.typ);
                  Console.Write("   " + p.language);
                  Console.Write("   " + p.programmer);
                  Console.Write("   " + p.discription);
                  Console.Write("   " + p.fromto);
                  Console.WriteLine("   " + p.github);
               }
            }
         }
         static void giveall() {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("      ..........................................");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("      Name ");
            Console.Write("  -    Typ ");
            Console.Write("  -    Language ");
            Console.Write("  -    Programmer ");
            Console.Write("  -    Discription ");
            Console.Write("  -    From-To ");
            Console.WriteLine("  -    On GitHub ");
            Console.WriteLine("");
            
            foreach (Proj p in projects) {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.Write("      " + p.name + " :");
               Console.ForegroundColor = ConsoleColor.White;
               Console.Write("   " + p.typ);
               Console.Write("   " + p.language);
               Console.Write("   " + p.programmer);
               Console.Write("   " + p.discription);
               Console.Write("   " + p.fromto);
               Console.WriteLine("   " + p.github);
            }
         }

         static void create() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Typ :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string typ = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Name :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Language :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string language = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      from - to :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string fromto = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Programmer :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string programmer = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Discription :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string discription = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      on GitHub (yes / no) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string github = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("     Loading...");
            Thread.Sleep(800);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Name :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Typ :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(typ);
            Console.WriteLine("");
            Console.Write("      Language :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(language);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Discription :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(discription);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Programmer :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(programmer);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      from - to :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(fromto);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      on GitHub (yes / no) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(github);

            Console.WriteLine ("");
            Console.WriteLine ("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write ("      Are you sure (yes / no) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            
            if (Console.ReadLine() == "yes") {
               Proj p = new Proj(name,typ,github,programmer,discription,fromto,language);
               projects.Add(p);
               
               return;
            } else {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("  -------------------------- Restart -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
               restart = true;
               start();
            }
            
         }


         static void load() {
           Stream stream;

            IFormatter formatter = new BinaryFormatter();  
            try {
                stream = new FileStream("MyFile.bin",FileMode.Open,FileAccess.Read);
                
                 projects = (List<Proj>)formatter.Deserialize(stream);
                 Console.WriteLine("Du hast {0} Projekte",projects.Count);

                stream.Close();
            } catch(FileNotFoundException exception)
            {           
                System.IO.FileStream fs = System.IO.File.Create("MyFile.bin");
                fs.Close();
            }
         }

      static void save () {
                  Stream stream;
                  IFormatter formatter = new BinaryFormatter(); 

                  try {
                     stream = new FileStream("MyFile.bin",FileMode.Open,FileAccess.Write);
                     
                     formatter.Serialize(stream,projects);
                     stream.Close();
                  } catch(FileNotFoundException exception) {
                     Console.WriteLine("should never happen");
                  }
               
      }
   }
}
          
     
