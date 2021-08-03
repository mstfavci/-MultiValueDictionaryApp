# Multi-Value Dictionary Application

Multi-Value Dictionary Application is a command line application that stores a multivalue dictionary in memory

## Installation

Download the code and build and run it with Visual Studio 2019.

## Requirements

.NET Core 3.1

## Command List

- EXIT: Exits the program,  
- KEYS: Return all the keys in the dictionary. Example: KEYS  
- ADD: Adds a member to a collection for a given key. Example: ADD foo  
- MEMBERS: Returns the collection of the strings for the given key. Example: MEMBERS foo  
- REMOVE: Removes a member from a key. Example: REMOVE foo bar  
- REMOVEALL: Removes all members for a key and removes the key from the dictionary. Example: REMOVEALL foo  
- CLEAR: Removes all keys and all members from the dictionary. Example: CLEAR  
- KEYEXISTS: Returns whether a key exists or not. Example: KEYEXISTS foo  
- MEMBEREXISTS: Returns whether a member exists within a key. Returns falls if the key does not exist. Example: MEMBEREXISTS foo bar  
- ALLMEMBERS: Returns all the members in the dictionary. Example: ALLMEMBERS  
- ITEMS: Returns all the keys in the dictionary and all of their members. Example: ITEMS


## License
[MIT](https://choosealicense.com/licenses/mit/)
