using System.Collections.Generic;

namespace Candidate.Domain.Entities
{
    public class Country
    {
        public Country()
        {
            States = new List<State>();
        }

        public string Description { get; set; }

        public ICollection<State> States { get; set; }
    }
}