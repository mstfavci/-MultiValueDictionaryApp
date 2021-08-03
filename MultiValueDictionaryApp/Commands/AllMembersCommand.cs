using System;
using System.Collections.Generic;

namespace MultiValueDictionaryApp.Commands
{
    public class AllMembersCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            var members = dic.GetMembers();
            if (members.Count == 0)
            {
                Console.WriteLine("(empty set)");
                return;
            }
            var i = 0;
            foreach (var item in members)
            {
                i++;
                Console.WriteLine($"{i}) {item}");
            }
        }
    }
}
