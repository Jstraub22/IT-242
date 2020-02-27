using System;
using System.Collections.Generic;

namespace chapter5_3
{
    class Program
    {
        static void Main(string[] args)
        {


            // Make a new empty List, we will be creating a List of Dictionary's
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();



            //create an empty Dictionary named 'excited' then use .Add to insert some key/value pairs, we will add this to the empty list called 'dictionaryOfWords'
            Dictionary<string, string> excited = new Dictionary<string, string>();

            excited.Add("shoes", "socks");
            excited.Add("ambulance", "weeoooooweeeeeoooo");
            excited.Add("ceiling shots", "=bangers");
            excited.Add("i am", "Hungry");

            dictionaryOfWords.Add(excited);



            Dictionary<string, string> money = new Dictionary<string, string>();

            money.Add("1$", "5$");
            money.Add("2$", "10$");
            money.Add("20$", "50$");
            money.Add("100$", "cents");



            dictionaryOfWords.Add(money);

            Dictionary<string, string> languages = new Dictionary<string, string>();

            languages.Add("english", "spanish");
            languages.Add("morrocan", "japanese");
            languages.Add("french", "latin");
            languages.Add("haitian", "puerto rico");



            dictionaryOfWords.Add(languages);

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
               {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            // excitedWord.Add();

            // Add Dictionary to your `dictionaryOfWords` list


            // create another Dictionary and add that to the list


            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries with a foreach loop inside another foreach loop
            //a foreach loop inside another foreach loop
            foreach (Dictionary<string, string> list in dictionaryOfWords)
            {

                Console.WriteLine("------");
                foreach (KeyValuePair<string, string> word in list)
                {

                    Console.WriteLine($"{word.Key}: {word.Value} ");
                }

            }
        }
    }
}

        
    




    
        
    

