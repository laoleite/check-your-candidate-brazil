using System.IO;
using Candidate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Candidate.Infrastructure.Data.Context
{
    public class CandidateDataContext : DbContext
    {
        public virtual DbSet<Domain.Entities.Candidate> Candidates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<ElectoralDoc> ElectoralDocs { get; set; }
        public virtual DbSet<Involvement> Involvements { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSocialMedia> UserSocialMedias { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
        }
    }
}
