using System;
using Base.Interfaces;
using JSonConfiguration;

namespace FactoryPattern.ConfigRepository
{
    /// <summary>
    /// Factory Design pattern: Concrete Creator
    /// Repo factory for new JSON format of repo
    /// </summary>
    public class JSonRepoFactory : ConfigRepoFactory
    {
        private JsonConfig jsonConfig;

        public override IConfig GetConfig()
        {
            if (jsonConfig == null)
            {
                jsonConfig = new JsonConfig();
            }

            return jsonConfig;
        }
    }
}
