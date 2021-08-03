using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp.Commands
{
    public class ClearCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            dic.Clear();
            Console.WriteLine("Cleared");
        }
    }
}
