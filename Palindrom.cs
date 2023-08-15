using System;
using System.Text.RegularExpressions;

class Program{
    static bool PalindromCheck(){
        Console.WriteLine("Enter Input String: ");
        string inputString = Console.ReadLine();
        string withoutPunctuations = Regex.Replace(inputString.ToLower(), @"[\p{P}-[.]]+", "");
        string withoutWhiteSpaces = Regex.Replace(withoutPunctuations, @"\s+", "");

        int i = 0;
        int j = withoutWhiteSpaces.Length - 1;
        while (i <= j){
            if (withoutWhiteSpaces[i] != withoutWhiteSpaces[j]){
                return false;
            }
            else{
                i += 1;
                j -= 1;
            }
        }

        return true;
    }

    static void Main(string[] args){
        bool ans = PalindromCheck();
        Console.WriteLine(ans);
    }
}