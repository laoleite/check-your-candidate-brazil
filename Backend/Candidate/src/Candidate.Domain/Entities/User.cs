using System.Collections.Generic;

namespace Candidate.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Avatar { get; set; }

        public Person Person { get; set; }

        public ICollection<UserSocialMedia> UserSocialMedias { get; set; }

        public Profile Profile { get; set; }
    }
}