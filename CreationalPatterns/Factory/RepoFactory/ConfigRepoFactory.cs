using System;
using System.Text;
using Base.Interfaces;
using CSVConfiguration;
using JSonConfiguration;

namespace FactoryPattern.ConfigRepository
{
    /// <summary>
    /// Base creator class
    /// </summary>
    public abstract class ConfigRepoFactory
    {
        /// <summary>
        /// Factory Design pattern: Creator
        /// Instance of the concrete factory
        /// There are many variations possible for the GetProduct() method
        /// - Can have factory method, where the decision of which product to create is made using a paramter
        /// - Can have concrete creator which makes the decision of how to create concrete product (as in this example)
        /// - can have default implementation in the base class of creator
        /// </summary>
        /// <returns></returns>
        public abstract IConfig GetConfig();
       
    }

   

    
}
