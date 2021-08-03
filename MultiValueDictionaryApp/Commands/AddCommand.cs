using MultiValueDictionaryApp.Exceptions;
using System;

namespace MultiValueDictionaryApp.Commands
{
    public class AddCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            if (userCommand.Key == null)
            {
                Console.WriteLine("ERROR, please enter a key");
                return;
            }

            try
            {
                dic.Add(userCommand.Key, userCommand.Value);
                Console.WriteLine("Added");
            }
            catch (MemberExistException)
            {
                Console.WriteLine("ERROR, member already exists for key");
            }
        }
    }
}
