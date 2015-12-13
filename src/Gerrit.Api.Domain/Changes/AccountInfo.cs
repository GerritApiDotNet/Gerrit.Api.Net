using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    public class AccountInfo
    {
        [JsonProperty("_account_id")]
        public string AccountId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public List<Avatar> Avatars { get; set; }
    }
}