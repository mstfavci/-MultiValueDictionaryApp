using MultiValueDictionaryApp.Exceptions;
using System;

namespace MultiValueDictionaryApp.Commands
{
    public class RemoveCommand<TKey, TValue> : ICommand<TKey, TValue>
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
                dic.RemoveMember(userCommand.Key, userCommand.Value);
                Console.WriteLine("Removed");
            }
            catch (KeyDoesNotExistException)
            {
                Console.WriteLine("ERROR, key does not exit");
            }
            catch (MemberDoesNotExistException)
            {
                Console.WriteLine("ERROR, member does not exit");
            }
        }
    }
}
