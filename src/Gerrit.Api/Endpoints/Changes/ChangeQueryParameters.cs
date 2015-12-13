using Gerrit.Api.Domain.Changes;

namespace Gerrit.Api.Endpoints.Changes
{
    public class ChangeQueryParameters
    {
        public static ChangeQueryParameters Empty => new ChangeQueryParameters();

        public int NumberOfResults { get; set; }

        public ChangeInfoStatus? Status { get; set; }

        public bool ReviewedByMe { get; set; }
    }
}
