using System;

namespace MultiValueDictionaryApp.Commands
{
    public class ItemsCommand<TKey, TValue> : ICommand<TKey, TValue>
    {
        public void Run(MultiValueDictionary<TKey, TValue> dic, IUserCommand<TKey, TValue> userCommand)
        {
            if (dic.Dictionary.Count == 0)
            {
                Console.WriteLine("(empty set)");
                return;
            }
            var i = 0;

            foreach (var item in dic.Dictionary)
            {
                foreach (var itemValue in item.Value)
                {
                    i++;
                    Console.WriteLine($"{i}) {item.Key}: {itemValue}");
                }
            }
        }
    }
}
