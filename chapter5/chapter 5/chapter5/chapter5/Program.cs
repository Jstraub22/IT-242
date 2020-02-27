using System;
using System.Collections.Generic;

namespace chapter5
{
    class Program
    {
        static void Main(string[] args)
        {

            //List in C# is similar to an array, 
            //This is a dictionary that is of type 'string' and type 'List', the key is the 'string' and the value is a 'List" of type 'strings'
            //ex: "Penny" = idioms[0].key
            Dictionary<string, List<string>> NCAA = new Dictionary<string, List<string>>();
            NCAA.Add("Big-10", new List<string> { "OSU", "Mich", "Pennst", "Northwestern", "Purd" });
            NCAA.Add("Big-12", new List<string> { "ISU", "K-st", "WV", "kansas" });
            NCAA.Add("SEC", new List<string> { "Bama", "LSu", "ole miss", "mizzou", "UGA" });
            NCAA.Add("American", new List<string> { "UCF", "UH", "Memphis", "Louisville", "ecu", "lil wayne" });
            NCAA.Add("C-usa", new List<string> { "MU", "MTSU", "69ers", "wku", "FAu", "fiu" });
            NCAA.Add("Pac-12", new List<string> { "oregon", "utah", "USC", "ucla", "cal", "Utah-st", "sdsu" });
            NCAA.Add("Mountain West", new List<string> { "boise", "idaho", "wyoming", "team", "2", "3", "4", "of", "salt" });
            NCAA.Add("Mac", new List<string> { "I'm", "akron", "toledo", "ohio", "about", "it" });
            NCAA.Add("Sun Belt", new List<string> { "lst", "nbayb", "wool", "over", "loser", "eyes" });
            NCAA.Add("ACC", new List<string> { "Speak", "of", "the", "devil" });


            //This is how you access and loop through a single item in the dictionary 'idioms' 
            //will pirint every word(value) in list with key of "Moon"
            foreach (string value in NCAA["ACC"])
            {
                Console.WriteLine(value);
            }


            //this is to put a space between the words so the sentence is readable
            string emptySpace = " ";

            //Loop through the Dictionary with foreach and use .Join() to combine all the words in the 
            foreach (string key in NCAA.Keys)

            {
                string results = String.Join(emptySpace, NCAA[key]);
                Console.WriteLine($"{key}: {results} ");







                Console.WriteLine("Hello World!");
            }
        }
    }
}
