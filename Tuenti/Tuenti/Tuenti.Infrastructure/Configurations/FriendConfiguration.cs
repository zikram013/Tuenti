using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Tuenti.Infrastucture.Configurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder) 
        {
            builder.ToTable("Friend");

            builder.HasKey(x => x.Id);
            builder.HasOne(f=>f.User)
                .WithMany(u=>u.Friends)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(f=>f.FriendUser)
                .WithMany()
                .HasForeignKey(f=>f.FriendUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
