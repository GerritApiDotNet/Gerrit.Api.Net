using System;
using Gerrit.Api.Common.Configuration;
using Gerrit.Api.Endpoints.Changes;

namespace Gerrit.Api.QuickStart
{
    public class Program
    {
        static void Main()
        {
            var gerritConfiguration = new GerritConfiguration("username", "password", "gerrit url");
            var changesEndPoint = new ChangesEndpoint(gerritConfiguration);

            foreach (var change in changesEndPoint.GetAll(new ChangeQueryParameters {NumberOfResults = 10}, ChangeOptionalParameters.Empty))
            {
                Console.WriteLine(change.Subject);
            }
        }
    }
}
