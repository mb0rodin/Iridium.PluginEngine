using CookieIoC;
using System;
using System.Collections.Generic;

namespace Iridium.PluginEngine
{
    public class ComponentRegistry
    {
        private IoCRealm iocRealm = new IoCRealm();

        public object Get(Type t, string contract = null)
        {
            return iocRealm.Get(t, contract);
        }

        /// <summary>
        /// Retrieve a previously registered component based on a type interface
        /// </summary>
        /// <typeparam name="T">The type interface of the component to find</typeparam>
        /// <param name="contract"></param>
        /// <returns></returns>
        public T Get<T>(string contract = null)
        {
            return (T)Get(typeof(T), contract);
        }

        public IEnumerable<T> GetAll<T>(string contract = null)
        {
            return iocRealm.GetAll<T>(contract);
        }

        /// <summary>
        /// Register a component with a type interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">An instance of a class that implements the specified type interface</param>
        /// <param name="type">
        ///     The type interface to register the component with. Usually, you can get this with typeof(T)
        /// </param>
        public void Register<T>(T instance, Type type)
        {
            iocRealm.RegisterConstant(instance, type);
        }
    }
}