using System;
using System.Collections.Generic;

namespace list_of_dictionaries

{
    class Program
    {
        static void Main(string[] args)
        {

            // New list
            var dictionaryOfWords = new List<Dictionary<string, string>>();

            // new dictionary inside that list
            var excitedWord = new Dictionary<string, string>();

            excitedWord.Add("word", "Excited");
            excitedWord.Add("definition", "Having, showing, or characterized by a heightened state of energy");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#");

            dictionaryOfWords.Add(excitedWord);


            var stokedWord = new Dictionary<string, string>();

            stokedWord.Add("word", "Stoked");
            stokedWord.Add("definition", "Feeling the dankness of something awesome");
            stokedWord.Add("part of speech", "Verb");
            stokedWord.Add("example sentence", "I could get stoked to shred some gnar later this afternoon");

            dictionaryOfWords.Add(stokedWord);

            //display to the console
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                foreach (KeyValuePair<string, string> item in word)
                {
                    Console.Write($"{item.Key}: {item.Value}");
                }
            }



            /*
            You want to track the following about each word:
                word, definition, part of speech, example sentence
            */

        }









    }
}

