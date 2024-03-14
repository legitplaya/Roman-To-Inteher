using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

public class Solution
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter your Roman(I,V,X,L,C,D,M) to Integer: ");
                Solution s = new Solution();
                int result = s.RomanToInt(Console.ReadLine().ToUpper());
                Console.WriteLine("Integer: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка введите Roman цифры");
            }
            Console.WriteLine("Vzlom казино...");
            Console.ReadKey();
            Console.Clear();
        }

    }
    public int RomanToInt(string s)
    {

        Dictionary<char, int> Roman = new Dictionary<char, int>()
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++) //ebawl matb zadania :)
        {
            if (i > 0 && Roman[s[i]] > Roman[s[i - 1]]) //ebawl matb zadania :)
            {
                result += Roman[s[i]] - 2 * Roman[s[i - 1]]; //ebawl matb zadania :)
            }
            else
            {
                result += Roman[s[i]]; //ebawl matb zadania :)
            }
        }
        return result; //ebawl matb zadania :)

    }

}