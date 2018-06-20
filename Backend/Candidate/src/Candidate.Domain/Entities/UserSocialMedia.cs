using System;

namespace Candidate.Domain.Entities
{
    public class UserSocialMedia : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Provider { get; set; }

        public string ProviderKey { get; set; }
    }
}