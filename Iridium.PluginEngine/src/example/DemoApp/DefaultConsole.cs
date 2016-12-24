using DemoPlugins.Sdk;
using System;

namespace DemoApp
{
    public class DefaultConsole : IConsole
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}