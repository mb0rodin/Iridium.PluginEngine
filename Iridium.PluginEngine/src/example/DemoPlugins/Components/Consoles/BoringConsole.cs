using DemoPlugins.Sdk;
using System;

namespace DemoPlugins.Components.Consoles
{
    internal class BoringConsole : IConsole
    {
        public void WriteLine(string str)
        {
            Console.WriteLine($"[boring] {str}. MEH.");
        }
    }
}