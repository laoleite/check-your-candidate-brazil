using System.Collections.Generic;

namespace Candidate.Domain.Entities
{
    public class State : BaseEntity
    {
        public State()
        {
            Cities = new List<City>();
        }

        public string Description { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}