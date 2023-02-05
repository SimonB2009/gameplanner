using System;
using System.Net;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Softplanner
{  
   public class Proj 
   {
      private string name;
      public Proj(string name, string typ, string github, string programmer, string discription, string fromto) {
          this.name = name;
      }
   } 
   
   
   public class Softplanner {

         static string action = "";
         static bool restart = false;
         static List<Proj> projects = new List<Proj> {};
         static void Main(string[] args) {
            load();
            start();
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
            Console.Write("      Action (show / new) :  ");
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

               if (action == "show") {
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("  -------------------------- Show -----------------------------");
                  Console.ForegroundColor = ConsoleColor.White; 
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
            
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
               Proj p = new Proj(name,typ,github,programmer,discription,fromto);
               projects.Add(p);

               bool test = true;
               if (test == false) {
                  restart = true;                                             //TODO
                  start();
               }
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
           /* Stream stream;

            IFormatter formatter = new BinaryFormatter();  
            try {
                stream = new FileStream(@"MyFile.bin",FileMode.Open,FileAccess.Read);
                
                test = (test[])formatter.Deserialize(stream);
                stream.Close();
            } catch(FileNotFoundException exception)
            {
                for (int i=0; i<10; i++) {
                    scores[i] = new Score();
                }
                System.IO.FileStream fs = System.IO.File.Create("MyFile.bin");
                fs.Close();
            }*/
         }
     }
}