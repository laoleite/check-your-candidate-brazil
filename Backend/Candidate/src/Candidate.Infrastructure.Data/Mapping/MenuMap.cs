using Candidate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Candidate.Infrastructure.Data.Mapping
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).HasDefaultValueSql("uuid_generate_v4()");
            builder.Property(b => b.InsertDate).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            builder.Property(b => b.Deleted).HasDefaultValueSql("((0))");
            builder.Property(b => b.Name).HasMaxLength(255);
            builder.Property(b => b.Url).HasMaxLength(255);
            builder.Property(b => b.Parent).HasDefaultValueSql("uuid_generate_v4()");
            
        }
    }
}
