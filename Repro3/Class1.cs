using System;

namespace Repro3
{
    public class Class1
    {
        public string GetConfig()
        {
            return System.Configuration.ConfigurationManager.AppSettings["foobar"];
        }
    }
}
