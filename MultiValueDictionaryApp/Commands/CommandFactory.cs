using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp.Commands
{
    public class CommandFactory
    {
        public static ICommand<TKey, TValue> getCommand<TKey, TValue>(string command)
        {
            switch (command.ToUpper())
            {
                case "HELP":
                    return new HelpCommand<TKey, TValue>();
                case "KEYS":
                    return new KeysCommand<TKey, TValue>();
                case "ADD":
                    return new AddCommand<TKey, TValue>();
                case "MEMBERS":
                    return new MembersCommand<TKey, TValue>();
                case "REMOVE":
                    return new RemoveCommand<TKey, TValue>();
                case "REMOVEALL":
                    return new RemoveAllCommand<TKey, TValue>();
                case "CLEAR":
                    return new ClearCommand<TKey, TValue>();
                case "KEYEXISTS":
                    return new KeyExistsCommand<TKey, TValue>();
                case "MEMBEREXISTS":
                    return new MemberExistsCommand<TKey, TValue>();
                case "ALLMEMBERS":
                    return new AllMembersCommand<TKey, TValue>();
                case "ITEMS":
                    return new ItemsCommand<TKey, TValue>();
                default:
                    throw new Exception("NOT IMPLEMENTED");
            }
        }
    }
}
