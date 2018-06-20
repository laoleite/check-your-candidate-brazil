using System;

namespace Candidate.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public Guid Parent { get; set; }
    }
}