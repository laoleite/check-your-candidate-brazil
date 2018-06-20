namespace Candidate.Domain.Entities
{
    public class Vote : BaseEntity
    {
        public User User { get; set; }

        public Candidate Candidate { get; set; }
    }
}