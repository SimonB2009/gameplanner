using System;
using System.Net;
using System.Text;

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
               Console.WriteLine("  -------------------------- Updating -----------------------------");
               Console.ForegroundColor = ConsoleColor.White; 
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Green;
               load();
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
            // Create web client simulating IE6.
            using (WebClient client = new WebClient())
            {
            client.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";
            
            // Download data.games
            byte[] arr = client.DownloadData("https://play.google.com/store/games");

            string str = Encoding.Default.GetString(arr);
            int index = str.IndexOf("Stumble Guys");
            Console.WriteLine(index);
            // Write values.
         
            //Console.WriteLine(str);

            show();
            }
         }

         static void show() {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  -------------------------- Show -----------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
         }
     }
}