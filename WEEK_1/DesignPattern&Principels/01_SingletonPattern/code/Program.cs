// Program.cs
using System;

class Program {
    static void Main(string[] args) {
        
        ILogger logger1 = Logger.GetInstance();
        ILogger logger2 = Logger.GetInstance();

        logger1.Log("Singleton is working");
        logger2.Log("Singleton is workinggg!");

        if (logger1 == logger2) {
            Console.WriteLine(":) Success: Both loggers are the same instance!");
        }

        else {
            Console.WriteLine(":( Error: Both loggers are Different instances!");
        }

        Console.ReadKey();
    }
}