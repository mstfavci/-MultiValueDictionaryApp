using System;

namespace MultiValueDictionaryApp.Commands
{
    public class KeysCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            var keys = dic.GetKeys();
            if (keys.Count == 0)
            {
                Console.WriteLine("(empty set)");
                return;
            }
            var i = 0;
            foreach (var item in keys)
            {
                i++;
                Console.WriteLine($"{i}) {item}");
            }
        }
    }
}
