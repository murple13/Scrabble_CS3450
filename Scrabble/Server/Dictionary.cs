using System;
using System.Collections.Generic;
using System.IO;


namespace Scrabble.Server
{
    /// <summary>
    /// Reads a text file containing the dictionary into a list. Prints error 
    /// message to console if dictionary is not found. Has method 
    /// containsWord(string word) that checks if a given word is in the 
    /// dictionary. 
    /// </summary>
    public class Dictionary
    {
        private List<String> dictionary = new List<String>();
        /// <summary>
        /// Takes in a dictionary text file, reads the contents to a list.
        /// </summary>
        /// <param name="filename"></param>
        public Dictionary(String filename)
        {
            try
            {
                using (StreamReader fileIn = new StreamReader(filename))
                {
                    string line;
                    while ((line = fileIn.ReadLine()) != null)
                    {
                        dictionary.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Dictionary file could not be opened.");
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Checks to see if a word is contained in the dictionary by using List.Contains(word)
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool containsWord(String word)
        {
            if (dictionary.Contains(word)) { return true; }
            else { return false; }
        }
    }
}
