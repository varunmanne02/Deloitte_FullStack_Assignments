using System;
using System.Collections.Generic;

class Program
{


    public static void Main()
    {

        // Create a new dictionary of
        // strings, with string keys.
        Dictionary<string, long> myDict =
          new Dictionary<string, long>();

        // Adding key/value pairs in myDict
        myDict.Add("Ajay", 9476455589);
        myDict.Add("Mahesh", 9845677789);
        myDict.Add("Krishna", 6789567823);
        myDict.Add("Prakash", 9904458976);
        myDict.Add("Rahul", 8907865734);
        myDict.Add("Vishal", 9876734234);

        // To get count of key/value pairs in myDict
        Console.WriteLine("Total key/value pairs" +
              " in myDict are : " + myDict.Count);

        myDict.Remove("Krishna");

        // Displaying the key/value pairs in myDict
        Console.WriteLine("\nThe key/value pairs" +
                           " in myDict are : ");

        foreach (KeyValuePair<string, long> kvp in myDict)
        {
            Console.WriteLine("Key = {0}, Value = {1}",
                              kvp.Key, kvp.Value);
        }

        Console.ReadLine();
    }
}