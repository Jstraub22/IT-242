using System;
using System.Collections.Generic;

namespace chapter_5_dictionaryofwords
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> socialMedia = new Dictionary<string, string>(){
                {"Twitter", "Arguing "},
                {"Instagram", "cool pics"},
                {"Reddit", "the best;)"}
            };

            // Add several more words and their definitions
            socialMedia.Add("Facebook", "Old People platform");
            socialMedia.Add("Tumblr", "Nerds");
            socialMedia.Add("4chan", "EDGY");
            
            Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
            Console.WriteLine(socialMedia["Reddit"]);
            Console.WriteLine(socialMedia["Ifunny"]);

            foreach (KeyValuePair<string, string> word in socialMedia)
            {
                Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
            }






        }
    }
}
