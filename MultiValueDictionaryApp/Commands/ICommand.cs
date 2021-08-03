using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp.Commands
{
    public interface ICommand<TKey,TValue>
    {
        void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand);
    }
}
