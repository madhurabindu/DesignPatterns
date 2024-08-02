using System;
using System.Drawing;
using Base.Interfaces;
using Imp.ResourceManagerImpl;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call to singleton..");

            IResourceManager resourceManager= ResourceManager.Instance;

            string str = resourceManager.GetString("string.title");
            Console.WriteLine("Value Returned: {0}", str);

            Image image = resourceManager.GetImage("logox32");
            image = resourceManager.GetImageFromFile("./Resources/logo128.png");

        }
    }
}
