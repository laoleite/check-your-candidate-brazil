using System.Collections.Generic;

namespace Candidate.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string Code { get; set; }

        public Party Party { get; set; }

        public string Avatar { get; set; }

        public Person Person { get; set; }

        public ICollection<Involvement> Involvements { get; set; }

        public Candidate Vice { get; set; }
    }
}