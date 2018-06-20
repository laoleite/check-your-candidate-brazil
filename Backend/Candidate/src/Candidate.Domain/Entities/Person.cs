using System;
using Candidate.Domain.Enums;

namespace Candidate.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Profession { get; set; }

        public EducationLevel EducationLevel { get; set; }

        public City City { get; set; }

        public ElectoralDoc ElectoralDoc { get; set; }
    }
}