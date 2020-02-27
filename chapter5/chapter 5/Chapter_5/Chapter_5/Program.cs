using System;
using System.Collections.Generic;

namespace Chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> moneyGained= new Dictionary<string, string>() {
                    {"Rocket league", "344"},
                    {"Legos", "763"},
                    {"Gaming Consoles", "551"},
                    {"Board Games","400" }
                };
            //////////////////////////////////////////////////////////////////////////////////////////
            ////how to use .Add(Key, Value) to add KeyValuePairs to the dictionary named "toysSold"///
            //////////////////////////////////////////////////////////////////////////////////////////
            //  "GI Joe" = Key   and   430 = Value || together they make a KeyValuePair
            moneyGained.Add("GI Joe", "430");
            //access and print this newly added Value(430) to the console by using the key of "GI Joe"
            Console.WriteLine(moneyGained["GI Joe"]);

            ////////////////////////////////////////////////////////////////////////
            ////How to loop over the dictionary and print each toy & its price/////
            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("****toysSold Dictionary****");//title of list you are about to print
            foreach (KeyValuePair<string, string> taco in moneyGained)
            {
                Console.WriteLine($"{taco.Key} price ${taco.Value}");

                Dictionary<int, string> top5VideoGames = new Dictionary<int, string>();

                top5VideoGames.Add(1, "Rocket League");
                top5VideoGames.Add(2, "MW2");
                top5VideoGames.Add(3, "R6");
                top5VideoGames.Add(4, "GTA");
                top5VideoGames.Add(5, "SKYRIM");

                //Now lets loop over the dictionary and print each key value pair to the Console
                //First lets print a title to the console
                Console.WriteLine("****Top 5 Video Games of all Time****");
                //loop over Dictionary and print each one
                foreach (KeyValuePair<int, string> game in top5VideoGames)
                {
                    Console.WriteLine(game.Key + " " + game.Value);
                }

                //how to check if an int(key) is in the dictionary -- here we check if the Dictionary has a key of 3
                Console.WriteLine("***How to check if a certain key exists in a dictionary with an if-else statement***");
                //create an empty variable
                string value;
                if (top5VideoGames.ContainsKey(3))
                {
                    value = top5VideoGames[3];
                    Console.WriteLine($"{value} exists in the dictionary");
                }
                else
                {
                    Console.WriteLine("Key Not Present");
                    return;
                }




            }



        }

        }
    }

