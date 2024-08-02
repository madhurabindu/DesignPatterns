using System;
using Base.Interfaces;
using Imp.XMLConfig;
using JSonConfiguration;

namespace FactoryPattern.ConfigRepository
{
    /// <summary>
    /// Factory Design pattern: Concrete Creator
    /// Repo factory for new JSON format of repo
    /// </summary>
    public class XMLRepoFactory : ConfigRepoFactory
    {
        private XMLConfig xmlConfig;

        public override IConfig GetConfig()
        {
            if (xmlConfig == null)
            {
                xmlConfig = new XMLConfig();
            }

            return xmlConfig;
        }
    }
}
