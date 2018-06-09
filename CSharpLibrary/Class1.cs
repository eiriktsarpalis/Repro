using Microsoft.Azure.Documents;
using System;

namespace CSharpLibrary
{
    public class Test
    {
        public static void PrintConsistencyLevel(ConsistencyLevel level) => level.ToString();
    }
}
