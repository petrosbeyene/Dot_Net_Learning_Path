// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// class WordFrequencyCounter
// {
//     public static Dictionary<string, int> CountWordFrequency(string input)
//     {
//         // Convert the input to lowercase and remove punctuation marks
//         string cleanedInput = Regex.Replace(input.ToLower(), @"[\p{P}-[._]]+", " ");
        
//         // Split the cleaned input into words
//         string[] words = cleanedInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//         // Count the frequency of each word
//         Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
//         foreach (string word in words)
//         {
//             if (wordFrequency.ContainsKey(word))
//             {
//                 wordFrequency[word]++;
//             }
//             else
//             {
//                 wordFrequency[word] = 1;
//             }
//         }

//         return wordFrequency;
//     }

//     static void Main(string[] args)
//     {
//         string input = "This is a test. This is only a test!";
//         Dictionary<string, int> frequency = CountWordFrequency(input);

//         foreach (var kvp in frequency)
//         {
//             Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//         }
//     }
// }
// See https://aka.ms/new-console-template for more information
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