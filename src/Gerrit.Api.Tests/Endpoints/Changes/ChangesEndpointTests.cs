using System.Collections.Generic;
using Gerrit.Api.Domain.Changes;
using Gerrit.Api.Endpoints.Changes;
using Gerrit.Api.Endpoints.Runner;
using Gerrit.Api.Tests.Common;
using Moq;
using NUnit.Framework;
using RestSharp;

namespace Gerrit.Api.Tests.Endpoints.Changes
{
    [TestFixture]
    public class ChangesEndpointTests
    {
        [Test]
        public void WhenGetAllIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.GetAll(ChangeQueryParameters.Empty, ChangeOptionalParameters.Empty);

            RestRequestRunnerAssert.VerifyRequest<List<ChangeInfo>>(restRequestRunnerMock, "/changes/?", Method.GET);
        }

        [Test]
        public void WhenGetIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();
            
            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.Get("1", ChangeQueryParameters.Empty, ChangeOptionalParameters.Empty);

            RestRequestRunnerAssert.VerifyRequest<ChangeInfo>(restRequestRunnerMock, "/changes/1/?", Method.GET);
        }

        [Test]
        public void WhenGetDetailsIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.GetDetails("1", ChangeQueryParameters.Empty, ChangeOptionalParameters.Empty);

            RestRequestRunnerAssert.VerifyRequest<ChangeInfo>(restRequestRunnerMock, "/changes/1/detail/?", Method.GET);
        }

        [Test]
        public void WhenGetTopicIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.GetTopic("1");

            RestRequestRunnerAssert.VerifyRequest<string>(restRequestRunnerMock, "/changes/1/topic/?", Method.GET);
        }

        [Test]
        public void WhenGetCommentsIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.GetComments("1");

            RestRequestRunnerAssert.VerifyRequest<Dictionary<string, List<CommentInfo>>>(restRequestRunnerMock, "/changes/1/comments/?", Method.GET);
        }

        [Test]
        public void WhenGetDraftCommentsIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.GetDraftComments("1");

            RestRequestRunnerAssert.VerifyRequest<Dictionary<string, List<CommentInfo>>>(restRequestRunnerMock, "/changes/1/drafts/?", Method.GET);
        }

        [Test]
        public void WhenCheckIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new ChangesEndpoint(restRequestRunnerMock.Object);
            sut.CheckChange("1");

            RestRequestRunnerAssert.VerifyRequest<ChangeInfo>(restRequestRunnerMock, "/changes/1/check/?", Method.GET);
        }
    }
}
