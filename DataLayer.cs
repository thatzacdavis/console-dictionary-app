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
        public static void AddMemberByKey(string key, string value)
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

        // List all keys of the dictionary or informs the user there are none.
        public static void GetAllKeys()
        {
            Dictionary<string, List<string>>.KeyCollection keys = _dictionary.Keys;
            if (keys.Count > 0)
            {
                foreach (string key in keys)
                {
                    Console.WriteLine(key);
                }
            }
            else
            {
                Console.WriteLine("There are no keys.");
            }
        }

        // Lists all the member sof a given key, or informs the user that
        // the key does not exist.
        public static void GetAllMembersByKey(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                KeyValuePair<string, List<string>> keyValuePair = _dictionary.First(item => item.Key == key);
                foreach (string subItem in keyValuePair.Value)
                {
                    Console.WriteLine(subItem);
                }
            }
            else
            {
                Console.WriteLine($"ERROR, key {key} does not exist.");
            }
        }

        // Removes a member for a key if they both exist.
        // Otherwise informs the user if either the key or the member does not.
        public static void RemoveMemberByKey(string key, string value)
        {
            if (_dictionary.ContainsKey(key))
            {
                var keyValuePair = _dictionary.First(item => item.Key == key);
                var subItem = keyValuePair.Value.FirstOrDefault(member => member == value);
                if (subItem != null)
                {
                    keyValuePair.Value.Remove(value);
                    Console.WriteLine($"Removed {value} from {key}.");
                }
                else
                {
                    Console.WriteLine($"ERROR, member {value} does not exist for key {key}.");
                }
            }
            else
            {
                Console.WriteLine($"ERROR, key {key} does not exist.");
            }
        }

        // Removes a KeyValuePair from the dictionary by key if it exists.
        // Otherwise informs the user that it does not exit.
        public static void RemoveKey(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                _dictionary.Remove(key);
            }
            else
            {
                Console.WriteLine($"Key {key} does not exist.");
            }
        }

        // Clears the entire dictionary by overwriting it.
        public static void ClearDictionary()
        {
            _dictionary = new Dictionary<string, List<string>>();
        }

        // Tells the user if a key exists or not.
        public static void KeyExists(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                Console.WriteLine($"The key {key} does exist!");
            }
            else
            {
                Console.WriteLine($"Sorry, key {key} does not exist :(");
            }
        }

        // Tells the user whether a member exists or if the requested key
        // or member does not.
        public static void MemberExists(string key, string member)
        {
            if (_dictionary.ContainsKey(key))
            {
                var keyValuePair = _dictionary.First(item => item.Key == key);
                if (keyValuePair.Value.Any(value => value == member))
                {
                    Console.WriteLine($"Member {member} for key {key} does exist!");
                }
                else
                {
                    Console.WriteLine($"Sorry, member {member} for key {key} does not exist :(");
                }
            }
            else
            {
                Console.WriteLine($"ERROR, key {key} does not exist.");
            }
        }

        // Returns all the members of a given key,
        // or informs the user that the key does not exist.
        public static void GetAllMembers(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                var keyValuePair = _dictionary.First(item => item.Key == key);
                foreach (string subItem in keyValuePair.Value)
                {
                    Console.WriteLine($"{subItem}");
                }
            }
            else
            {
                Console.WriteLine($"ERROR, key {key} does not exist.");
            }
        }

        // Prints out all keys and all members of each key.
        public static void GetAllItems()
        {
            if (_dictionary.Count > 0)
            {
                foreach(KeyValuePair<string, List<string>> keyValuePair in _dictionary)
                {
                    foreach(string subItem in keyValuePair.Value) 
                    {
                        Console.WriteLine($"{keyValuePair.Key}: {subItem}");
                    }
                }
            }
        }
    }
}