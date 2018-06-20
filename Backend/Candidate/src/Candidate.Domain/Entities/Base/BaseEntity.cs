using System;

namespace Candidate.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
        public bool Deleted { get; set; }
    }
}
