using System;
using System.Drawing;
using Base.Interfaces;

namespace Imp.ResourceManagerImpl
{
    /// <summary>
    /// Singleton class accessor, Singleton Factory
    /// </summary>
    public class ResourceManager 
    {
        /// <summary>
        /// Static instance
        /// </summary>
        private static InternalResourceManager instance;

        /// <summary>
        /// Static ctor
        /// </summary>
        static ResourceManager()
        {
            instance = new InternalResourceManager();
            instance.LoadResources();
        }

        /// <summary>
        /// Method to acces singleton isntance
        /// </summary>
        public static IResourceManager Instance { get { return instance; } }

        /// <summary>
        /// private ctor to disallow multiple instnace creation
        /// </summary>
        private ResourceManager()
        {

        }
       
    }
}
