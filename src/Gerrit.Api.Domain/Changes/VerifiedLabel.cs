using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    public class VerifiedLabel
    {
        public List<AccountInfoVote> All { get; set; }

        public Dictionary<int, string> Values { get; set; }
    }
}