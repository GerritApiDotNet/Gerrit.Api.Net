using Gerrit.Api.Endpoints.Runner;
using Moq;
using RestSharp;

namespace Gerrit.Api.Tests.Common
{
    public static class RestRequestRunnerAssert
    {
        public static void VerifyRequest<TReturnType>(Mock<IRestRequestRunner> restRequestRunnerMock, string resource, Method expectedMethod)
        {
            restRequestRunnerMock.Verify(mock => mock.ExecuteRequest<TReturnType>(It.Is<string>(request => request == resource),
                It.Is<Method>(method => method == expectedMethod)), Times.Once);
        }
    }
}
