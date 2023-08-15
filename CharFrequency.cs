// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

namespace CharFrequency{
    class Program{
        static Dictionary<char, int> countFrequency(){
            Console.WriteLine("Enter input stirng: ");
            string inputString = Console.ReadLine();
            string withoutPunctuations = Regex.Replace(inputString, @"[\p{P}-[.]]+", "");

            Dictionary<char, int> charFreq = new Dictionary<char, int>();
            foreach(char c in withoutPunctuations ){
                if (charFreq.ContainsKey(c)){
                    charFreq[c] += 1;
                }
                else{
                    charFreq[c] = 1;
                }
            }

            return charFreq;
        }

        static void Main(string[] args){
            Dictionary<char, int> ans = countFrequency();
            foreach (var kvp in ans)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}