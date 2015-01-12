using System.Data.Entity.ModelConfiguration;
using Mvp.Passive.View.Base.Model;

namespace Mvp.Passive.View.Base.Database.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.ToTable("User");

            this.Property(p => p.FirstName).IsRequired();

            this.Property(p => p.Surname).IsRequired();

            this.HasMany(e => e.Groups)
            .WithMany(e => e.Users)
            .Map(m =>
            {
                m.ToTable("UserGroup");
                m.MapLeftKey("User");
                m.MapRightKey("Group");
            });
        }
    }
}
