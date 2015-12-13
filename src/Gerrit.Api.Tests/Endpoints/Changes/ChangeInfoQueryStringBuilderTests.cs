using Gerrit.Api.Domain.Changes;
using Gerrit.Api.Endpoints.Changes;
using NUnit.Framework;

namespace Gerrit.Api.Tests.Endpoints.Changes
{
    [TestFixture]
    public class ChangeQueryStringBuilderTests
    {
        [Test]
        [TestCaseSource(nameof(_queryParammeters))]
        public void WhenNumberOfResultsIsSpecified_GetQueryString_ReturnsQueryWithNumberOfResults(ChangeQueryParameters parameters, string expectedResult)
        {
            var sut = new ChangeQueryStringBuilder();

            var result = sut.GetQueryString(parameters, ChangeOptionalParameters.Empty);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCaseSource(nameof(_optionalParameters))]
        public void WhenOptionalParameterIsSpecified_GetQueryString_IncludesOptionalParameter(ChangeOptionalParameters optionalParameters, string expectedResult)
        {
            var sut = new ChangeQueryStringBuilder();

            var result = sut.GetQueryString(ChangeQueryParameters.Empty, optionalParameters);

            Assert.AreEqual(expectedResult, result);
        }

        private static readonly object[] _queryParammeters =
        {
            new object[] { new ChangeQueryParameters { NumberOfResults = 5 }, "?n=5" },
            new object[] { new ChangeQueryParameters { Status = ChangeInfoStatus.New }, "?status:New" },
            new object[] { new ChangeQueryParameters { ReviewedByMe = true }, "?q=reviewer:self" },
        };

        private static readonly object[] _optionalParameters =
        {
            new object[] { new ChangeOptionalParameters { Labels = true }, "?o=LABELS"},
            new object[] { new ChangeOptionalParameters { DetailedLabels = true }, "?o=DETAILED_LABELS"},
            new object[] { new ChangeOptionalParameters { CurrentRevision = true }, "?o=CURRENT_REVISION"},
            new object[] { new ChangeOptionalParameters { AllRevisions = true }, "?o=ALL_REVISIONS"},
            new object[] { new ChangeOptionalParameters { DownloadCommands = true }, "?o=DOWNLOAD_COMMANDS"},
            new object[] { new ChangeOptionalParameters { DraftComments = true }, "?o=DRAFT_COMMENTS"},
            new object[] { new ChangeOptionalParameters { CurrentCommit = true }, "?o=CURRENT_COMMIT"},
            new object[] { new ChangeOptionalParameters { AllCommits = true }, "?o=ALL_COMMITS"},
            new object[] { new ChangeOptionalParameters { CurrentFiles = true }, "?o=CURRENT_FILES"},
            new object[] { new ChangeOptionalParameters { AllFiles = true }, "?o=ALL_FILES"},
            new object[] { new ChangeOptionalParameters { DetailedAccounts = true }, "?o=DETAILED_ACCOUNTS"},
            new object[] { new ChangeOptionalParameters { Messages = true }, "?o=MESSAGES"},
            new object[] { new ChangeOptionalParameters { CurrentActions = true }, "?o=CURRENT_ACTIONS"},
            new object[] { new ChangeOptionalParameters { ChangeActions = true }, "?o=CHANGE_ACTIONS"},
            new object[] { new ChangeOptionalParameters { Reviewed = true }, "?o=REVIEWED"},
            new object[] { new ChangeOptionalParameters { WebLinks = true }, "?o=WEB_LINKS"},
            new object[] { new ChangeOptionalParameters { Check = true }, "?o=CHECK"}
        };
    }
}