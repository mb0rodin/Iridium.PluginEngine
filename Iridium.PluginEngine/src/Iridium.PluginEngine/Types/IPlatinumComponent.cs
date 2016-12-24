using Iridium.PluginCore;
using System;
using System.Collections.Generic;

namespace Iridium.PluginEngine.Types
{
    public interface IPlatinumComponent : IPlatinumPlugin
    {
        Dictionary<Type, object> SubComponents { get; }
    }
}