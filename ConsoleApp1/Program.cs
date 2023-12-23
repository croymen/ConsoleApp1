// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Diagnostics;

Console.WriteLine("Hello, World 123!");


Thread backgroundThread = new Thread(new ThreadStart(Class1.DoSomeHeavyLifting));

// Start thread
backgroundThread.Start();