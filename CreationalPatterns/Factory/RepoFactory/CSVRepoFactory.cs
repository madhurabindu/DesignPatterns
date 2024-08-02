using System;
using Base.Interfaces;
using CSVConfiguration;

namespace FactoryPattern.ConfigRepository
{
    /// <summary>
    /// Factory Design pattern: Concrete Creator
    /// Repo factory for old CSV format of repo
    /// </summary>
    public class CSVRepoFactory : ConfigRepoFactory
    {
        private CSVConfig csvConfig;

        public override IConfig GetConfig()
        {
            if (csvConfig == null)
            {
                csvConfig = new CSVConfig();
            }

            return csvConfig;
        }
    }
}
