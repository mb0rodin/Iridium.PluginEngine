using Iridium.PluginCore;
using Iridium.PluginCore.Classes;
using System;
using System.Collections.Generic;

namespace Iridium.PluginEngine.Types
{
    public abstract class ComponentPlugin<T> : IPlatinumComponent
    {
        public abstract string Author { get; }
        public abstract string Description { get; }
        public virtual IPlatinumPluginHost Host { get; set; }
        public abstract string Name { get; }
        public abstract string PluginGuid { get; }
        public abstract string PreferencesKey { get; }
        public virtual Dictionary<Type, object> SubComponents { get; private set; }
        public abstract Version Version { get; }

        /// <summary>
        /// A component that can replace the another implementation
        /// </summary>
        public abstract T ComponentImplementation { get; protected set; }

        public abstract void ConfigurePlugin(PluginPreferences pluginSettings);

        public abstract void Dispose();

        public virtual void Initialize()
        {
            SubComponents = new Dictionary<Type, object>
            {
                { typeof(T), ComponentImplementation }
            };
        }

        public abstract void LoadComponents();

        public abstract void Shutdown();

        public abstract void UnloadComponents();
    }
}