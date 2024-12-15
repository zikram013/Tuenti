using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Tuenti.Infrastucture.Configurations
{
    public class PostConfiguration: IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder) 
        {
            builder.ToTable("Post");

            builder.HasKey(x => x.Id);

            builder.Property(p=>p.Content).IsRequired();

            builder.Property(p=>p.Title).IsRequired();

            builder.Property(p=>p.DatePosted).HasDefaultValueSql("GETDATE()");

            builder.HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p=>p.Comments).WithOne(p => p.Post).HasForeignKey(c=>c.PostId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
