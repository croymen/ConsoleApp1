// See https://aka.ms/new-console-template for more information
using ConsoleApp2.src;

Console.WriteLine("Hello, World 123!");


Thread backgroundThread = new Thread(new ThreadStart(ThreadUtils.DoSomeHeavyLifting));

// Start thread
backgroundThread.Start();