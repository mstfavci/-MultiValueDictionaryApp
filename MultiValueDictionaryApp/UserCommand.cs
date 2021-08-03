using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionaryApp
{
    public class UserCommand: IUserCommand<string, string>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Command { get; set; }
        public void parse(string userCommand)
        {
            var items = userCommand.Split(" ");
            Command = items.Length > 0 ? items[0] : null;
            Key = items.Length > 1 ? items[1] : null;
            Value = items.Length > 2 ? items[2] : null;
        }
    }
}
