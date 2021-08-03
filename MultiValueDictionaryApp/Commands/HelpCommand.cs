using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp.Commands
{
    public class HelpCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            Console.WriteLine("EXIT: Exits the program");
            Console.WriteLine("KEYS: Return all the keys in the dictionary. Example: KEYS");
            Console.WriteLine("ADD: Adds a member to a collection for a given key. Example: ADD foo");
            Console.WriteLine("MEMBERS: Returns the collection of the strings for the given key. Example: MEMBERS foo");
            Console.WriteLine("REMOVE: Removes a member from a key. Example: REMOVE foo bar");
            Console.WriteLine("REMOVEALL: Removes all members for a key and removes the key from the dictionary. Example: REMOVEALL foo");
            Console.WriteLine("CLEAR: Removes all keys and all members from the dictionary. Example: CLEAR");
            Console.WriteLine("KEYEXISTS: Returns whether a key exists or not. Example: KEYEXISTS foo");
            Console.WriteLine("MEMBEREXISTS: Returns whether a member exists within a key. Returns falls if the key does not exist. Example: MEMBEREXISTS foo bar");
            Console.WriteLine("ALLMEMBERS: Returns all the members in the dictionary. Example: ALLMEMBERS");
            Console.WriteLine("ITEMS: Returns all the keys in the dictionary and all of their members. Example: ITEMS");
        }
    }
}
