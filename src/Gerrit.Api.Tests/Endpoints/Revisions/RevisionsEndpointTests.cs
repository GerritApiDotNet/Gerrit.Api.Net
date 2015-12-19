using System.Collections.Generic;
using Gerrit.Api.Domain.Changes;
using Gerrit.Api.Endpoints.Revisions;
using Gerrit.Api.Endpoints.Runner;
using Gerrit.Api.Tests.Common;
using Moq;
using NUnit.Framework;
using RestSharp;

namespace Gerrit.Api.Tests.Endpoints.Revisions
{
    public class RevisionsEndpointTests
    {
        [Test]
        public void WhenGetAllIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new RevisionsEndpoint(restRequestRunnerMock.Object);
            sut.GetCommit("1", "2");

            RestRequestRunnerAssert.VerifyRequest<CommitInfo>(restRequestRunnerMock, "/changes/1/revisions/2/commit", Method.GET);
        }

        [Test]
        public void WhenGetRevisionActionsIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new RevisionsEndpoint(restRequestRunnerMock.Object);
            sut.GetRevisionActions("1", "2");

            RestRequestRunnerAssert.VerifyRequest<Dictionary<string, ActionInfo>>(restRequestRunnerMock, "/changes/1/revisions/2/actions", Method.GET);
        }

        [Test]
        public void WhenGetReviewActionsIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new RevisionsEndpoint(restRequestRunnerMock.Object);
            sut.GetReview("1", "2");

            RestRequestRunnerAssert.VerifyRequest<ChangeInfo>(restRequestRunnerMock, "/changes/1/revisions/2/review", Method.GET);
        }

        [Test]
        public void WhenGetRelatedChangesIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new RevisionsEndpoint(restRequestRunnerMock.Object);
            sut.GetRelatedChanges("1", "2");

            RestRequestRunnerAssert.VerifyRequest<RelatedChangesInfo>(restRequestRunnerMock, "/changes/1/revisions/2/related", Method.GET);
        }

        [Test]
        public void WhenGetCommentsActionsIsCalled_WithEmptyParams_CallsRequestRunnerWithCorrectUrlAndMethod()
        {
            var restRequestRunnerMock = new Mock<IRestRequestRunner>();

            var sut = new RevisionsEndpoint(restRequestRunnerMock.Object);
            sut.GetComments("1", "2");

            RestRequestRunnerAssert.VerifyRequest<Dictionary<string, List<CommentInfo>>>(restRequestRunnerMock, "/changes/1/revisions/2/comments", Method.GET);
        }
    }
}
