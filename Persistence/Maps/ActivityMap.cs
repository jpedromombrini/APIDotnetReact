using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;

namespace Persistence.Maps
{
    public class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder) 
        {
            builder.ToTable("Activity");
            builder.HasKey("Id");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)"); 
            builder.Property(x => x.Description).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Category).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Date).HasColumnType("DateTime");
            builder.Property(x => x.City).HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(x => x.Venue).HasMaxLength(30).HasColumnType("varchar(30)"); 

        }
        
    }
}