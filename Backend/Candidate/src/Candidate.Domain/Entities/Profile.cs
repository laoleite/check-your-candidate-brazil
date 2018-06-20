using System.Collections.Generic;
using Candidate.Domain.Enums;

namespace Candidate.Domain.Entities
{
    public class Profile : BaseEntity
    {
        public Profile()
        {
            Menus = new List<Menu>();
        }

        public string Name { get; set; }

        public TypeProfile TypeProfile { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}