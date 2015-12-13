using System;

namespace Gerrit.Api.Common.Settings
{
    public class ConfigurationProvider
    {
        private static readonly Lazy<ConfigurationProvider> _instance = new Lazy<ConfigurationProvider>(() => new ConfigurationProvider());
        private static GerritConfiguration _configuration;

        private ConfigurationProvider()
        {
        }

        public static ConfigurationProvider Instance => _instance.Value;

        public void UpdateConfiguration(GerritConfiguration gerritConfiguration)
        {
            _configuration = gerritConfiguration;
        }

        public GerritConfiguration GetConfiguration()
        {
            if (_configuration != null)
            {
                return _configuration;
            }

            var configurationSettings = ConfigurationSettings.Default;
            _configuration = new GerritConfiguration(configurationSettings.Username, configurationSettings.Password, configurationSettings.GerritApiUrl);

            return _configuration;
        }
    }
}
