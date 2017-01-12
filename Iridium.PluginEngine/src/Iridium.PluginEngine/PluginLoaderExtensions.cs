using Iridium.PluginCore;
using Iridium.PluginEngine.Types;

namespace Iridium.PluginEngine
{
    public static class PluginLoaderExtensions
    {
        /// <summary>
        /// Registers all subcomponents into the specified component registry from all the loaded component plugins
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pluginLoader"></param>
        /// <param name="target">The target registry</param>
        public static void RegisterAll<T>(this PluginLoader<T> pluginLoader, ComponentRegistry target) where T : IPlatinumComponent
        {
            foreach (var plugin in pluginLoader.Factory.AvailablePlugins)
            {
                foreach (var subcomponentMapping in plugin.Instance.SubComponents)
                {
                    target.Register(subcomponentMapping.Value, subcomponentMapping.Key);
                }
            }
        }
    }
}