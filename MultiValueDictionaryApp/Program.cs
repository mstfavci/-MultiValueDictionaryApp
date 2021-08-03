using System;
using MultiValueDictionaryApp.Commands;

namespace MultiValueDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Multi-Value Dictionary app is a command line application that stores a multivalue dictionary in memory.");
            Console.WriteLine("All Keys and members are strings.");
            Console.WriteLine("Type HELP to see the command list");
            string userCommandString = "";
            UserCommand uc = new UserCommand();
            var dictionary = new MultiValueDictionary<string, string>();
            while (true)
            {
                userCommandString = Console.ReadLine();
                if (userCommandString.ToUpper() == "EXIT")
                    break;

                uc.parse(userCommandString);

                var cmd = CommandFactory.getCommand<string, string>(uc.Command);
                cmd.Run(dictionary, uc);
            }
        }
    }
}
