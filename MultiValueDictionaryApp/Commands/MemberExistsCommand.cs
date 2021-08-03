using System;

namespace MultiValueDictionaryApp.Commands
{
    public class MemberExistsCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            Console.WriteLine(dic.MemberExists(userCommand.Key, userCommand.Value));
        }
    }
}
