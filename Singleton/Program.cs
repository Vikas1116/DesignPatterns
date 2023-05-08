// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

Database database = Database.getInstance();

database.someQuery();