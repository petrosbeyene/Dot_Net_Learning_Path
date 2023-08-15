using System;
using System.Text.RegularExpressions;

namespace wordFrequency{
    class Program{
        static Dictionary<string, int> countFrequency(string sentence){
            string modifiedSentence = sentence.Replace(".", "");
            string withoutPunctuations = Regex.Replace(modifiedSentence, @"[\p{P}-[._]]+", "");
            string[] words = withoutPunctuations.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach(string word in words ){
                if (wordFrequency.ContainsKey(word)){
                    wordFrequency[word] += 1;
                }
                else{
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }

        static void Main(string[] args){
            string input = "This is a test. This is only a test!"; 
            Dictionary<string, int> ans = countFrequency(input);
            foreach (var kvp in ans)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}