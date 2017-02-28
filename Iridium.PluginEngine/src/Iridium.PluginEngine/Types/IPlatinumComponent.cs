using Iridium.PluginCore;
using System;
using System.Collections.Generic;

namespace Iridium.PluginEngine.Types
{
    public interface IPlatinumComponent : IPlugin
    {
        Dictionary<Type, object> SubComponents { get; }
    }
}