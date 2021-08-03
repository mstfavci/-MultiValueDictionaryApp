using MultiValueDictionaryApp.Exceptions;
using System;

namespace MultiValueDictionaryApp.Commands
{
    public class RemoveAllCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            if (userCommand.Key == null)
            {
                Console.WriteLine("ERROR, please enter a key");
            }
            try
            {
                dic.RemoveKey(userCommand.Key);
                Console.WriteLine("Removed");
            }
            catch (KeyDoesNotExistException)
            {
                Console.WriteLine("ERROR, key does not exit");
            }
        }
    }
}
