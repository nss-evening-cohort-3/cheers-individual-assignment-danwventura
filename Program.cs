using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Variables Section
            String prompt="> ";
            
            String requires_an = "aeiolnfshrmx";
            String cheer_prefix = "Give me a";
            Console.WriteLine("What's your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower(); //Read from terminal save to a variable
            //Last Refactoring using .Contains in if statement
            for(int i = 0; i < user_name.Length; i++) {
                if(requires_an.Contains(user_name[i])){
                    Console.WriteLine(cheer_prefix + "n.." + user_name[i]);
                } else {
                    Console.WriteLine(cheer_prefix + ".." + user_name[i]);
                }
            }
            //First refactoring, removed else statement and moved prefix into for loop
            /*
            for(int i = 0; i < user_name.Length; i++) {
                String cheer_prefix = "Give me a"; //Resets the cheer_prefix variable every iteration through the loop
                if(requires_an.IndexOf(user_name[i]) > -1) {
                    cheer_prefix += "n";
                }
                 Console.WriteLine(cheer_prefix + ".." + user_name[i]);
            };
            */

            //Original solution
            /*for(int i = 0; i < user_name.Length; i++){
                if(requires_an.IndexOf(user_name[i]) > -1) {
                    //Then it's in the requires_an array!!!
                    Console.WriteLine(cheer_prefix + "n.." + user_name[i]);
                } else {
                    Console.WriteLine(cheer_prefix + ".." + user_name[i]);
                }
            }*/


            // user_name.ToUpper() is turning the user's name to uppercase
            //ToUpper() is functionality specific to strings
            //ToUpper() accepts no arguments
            Console.WriteLine(user_name.ToUpper() + " ..is GRAND!");
        }
    }
}
