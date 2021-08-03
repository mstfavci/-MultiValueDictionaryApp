using System;

namespace MultiValueDictionaryApp.Commands
{
    public class KeyExistsCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            Console.WriteLine(dic.KeyExists(userCommand.Key));
        }
    }
}
