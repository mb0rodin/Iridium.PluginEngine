using Iridium.PluginCore.Types;
using System;
using System.Collections.Generic;

namespace Iridium.PluginEngine.Types
{
    public abstract class ComponentPlugin<T> : IPlatinumComponent
    {
        public abstract string Name { get; }
        public abstract Version Version { get; }
        public abstract string PluginIdentifier { get; }

        public virtual string Author { get; }
        public virtual string Description { get; }
        public virtual string PreferencesKey { get; }
        public virtual Dictionary<Type, object> SubComponents { get; private set; }

        /// <summary>
        /// A component that can replace the another implementation
        /// </summary>
        public abstract T ComponentImplementation { get; protected set; }

        public virtual void Configure(PluginConfiguration pluginSettings)
        {
        }

        public virtual void Dispose()
        {
        }

        public virtual void Initialize()
        {
            SubComponents = new Dictionary<Type, object>
            {
                { typeof(T), ComponentImplementation }
            };
        }

        public virtual void LoadComponents()
        {
        }

        public virtual void Shutdown()
        {
        }

        public virtual void UnloadComponents()
        {
        }
    }
}