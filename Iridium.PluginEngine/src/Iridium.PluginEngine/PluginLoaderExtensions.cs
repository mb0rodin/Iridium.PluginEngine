using Iridium.PluginCore;
using Iridium.PluginEngine.Types;

namespace Iridium.PluginEngine
{
    public static class PluginLoaderExtensions
    {
        /// <summary>
        /// Registers all SubComponents in the global component registry from all the loaded component plugins
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pluginLoader"></param>
        public static void RegisterAll<T>(this PluginLoader<T> pluginLoader) where T : IPlatinumComponent
        {
            foreach (var plugin in pluginLoader.Factory.AvailablePlugins)
            {
                foreach (var subcomponentMapping in plugin.Instance.SubComponents)
                {
                    ComponentRegistry.Register(subcomponentMapping.Value, subcomponentMapping.Key);
                }
            }
        }
    }
}