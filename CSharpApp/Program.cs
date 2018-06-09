using System;

using Microsoft.Azure.Documents;

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CSharpLibrary.Test.PrintConsistencyLevel(ConsistencyLevel.Eventual));
        }
    }
}
