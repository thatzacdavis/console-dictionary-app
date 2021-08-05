using System.Collections.Generic;
using System;
using System.Linq;

namespace console_dictionary_app
{
    public class DataLayer
    {
        public static Dictionary<string, List<string>> _dictionary = new Dictionary<string, List<string>>();

        // Adds a member to the list of strings for an existing key,
        // or creates a new entry in the dictionary if the key does not exist.
        public static void Add(string key, string value)
        {
            if (!_dictionary.ContainsKey(key))
            {
                _dictionary.Add(key, new List<string>() { value });
            }
            else
            {
                KeyValuePair<string, List<string>> keyValuePair = _dictionary.First(item => item.Key == key);
                keyValuePair.Value.Add(value);
            }

        }

        public static void Keys()
        {
            Dictionary<string, List<string>>.KeyCollection keys = _dictionary.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
        }

        public static void Members(string key)
        {
            if(_dictionary.ContainsKey(key)) 
            {
                var items = _dictionary.First(item => item.Key == key);
                foreach (var item in items)
                {
                    foreach(var subItem in item.Value) 
                    {
                        Console.WriteLine(subItem);
                    }
                }
            }
            else 
            {
                Console.WriteLine($"ERROR, key {key} does not exist.");
            }
            
        }
    }
}