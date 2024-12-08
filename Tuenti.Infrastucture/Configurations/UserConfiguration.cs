using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Tuenti.Infrastucture.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.ToTable("Users");
        }
    }
}
