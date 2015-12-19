using RestSharp;

namespace Gerrit.Api.Endpoints.Runner
{
    public interface IRestRequestRunner
    {
        TEntity ExecuteRequest<TEntity>(string resource, Method method);
    }
}