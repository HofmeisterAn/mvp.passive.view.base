using System.Data.Entity.ModelConfiguration;
using Mvp.Passive.View.Base.Model;

namespace Mvp.Passive.View.Base.Database.Configuration
{
    public class GroupConfiguration : EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            this.ToTable("Group");

            this.Property(p => p.Name).IsRequired();

            this.HasMany(e => e.Users)
            .WithMany(e => e.Groups)
            .Map(m =>
            {
                m.ToTable("UserGroup");
                m.MapLeftKey("Group");
                m.MapRightKey("User");
            });
        }
    }
}
