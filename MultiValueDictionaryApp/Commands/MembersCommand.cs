using MultiValueDictionaryApp.Exceptions;
using System;
using System.Collections.Generic;

namespace MultiValueDictionaryApp.Commands
{
    public class MembersCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            if (userCommand.Key == null)
            {
                Console.WriteLine("ERROR, please enter a key");
                return;
            }

            if (!dic.KeyExists(userCommand.Key))
            {
                Console.WriteLine("ERROR, key does not exist");
                return;
            }

            var i = 0;
            foreach (var item in dic.Dictionary[userCommand.Key])
            {
                i++;
                Console.WriteLine($"{i}) {item}");
            }
        }
    }
}
