using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp
{
    public interface IUserCommand<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public string Command { get; set; }
    }
}
