namespace Gerrit.Api.Common.Configuration
{
    public class GerritConfiguration
    {
        public GerritConfiguration(string userName, string password, string gerritApiUrl)
        {
            UserName = userName;
            Password = password;
            GerritApiUrl = gerritApiUrl;
        }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        public string GerritApiUrl { get; private set; }
    }
}
