using System;

namespace Softplanner
{   class Softplanner  {

         static string places;
         static bool restart = false;
         static void Main(string[] args) {
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
            Console.Write("      places 0 - to :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            places = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.Write("      places 0 - ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(places);
            
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Are you sure (yes / no) : ");
            Console.ForegroundColor = ConsoleColor.Blue;

            if (Console.ReadLine() == "yes") {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("  -------------------------- Show -----------------------------");
               Console.ForegroundColor = ConsoleColor.White; 
               Console.WriteLine("");
               Console.WriteLine("");
               show();
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
     }
}