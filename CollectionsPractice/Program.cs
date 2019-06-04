using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main (string[] args)
        {
            // #1
            // Create an array to hold integer values 0 through 9
            int[] numArray = new int[10];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i;
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };

            // Create an array of length 10 that alternates between true and false values, starting with true
            Boolean[] boolArray = new Boolean[10];

            for (int i = 0; i < boolArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolArray[i] = true;
                }
                boolArray[i] = false;
            }

            // #2
            List<string> flavorList = new List<string> ();
            flavorList.Add ("Vanilla");
            flavorList.Add ("Chocolate");
            flavorList.Add ("Cookies and Cream");
            flavorList.Add ("Mint Chocolate Chip");
            flavorList.Add ("Strawberry");

            for (int i = 0; i < flavorList.Count; i++)
            {
                Console.WriteLine (flavorList[i]);
            }

            Console.WriteLine (flavorList[2]);
            flavorList.RemoveAt (2);
            Console.WriteLine (flavorList.Count);

            // #3
            Dictionary<string, string> dict = new Dictionary<string, string> ();
            dict.Add ("Tim", "Vanilla");
            dict.Add ("Martin", "Chocolate");
            dict.Add ("Nikki", "Cookies and Cream");
            dict.Add ("Sara", "Strawberry");

            foreach (KeyValuePair<string, string> name in dict)
            {
                Console.WriteLine (name.Key + " - " + name.Value);
            }
        }
    }
}