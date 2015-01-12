using System;
using System.Data.Entity;
using Mvp.Passive.View.Base.Model;
using Mvp.Passive.View.Base.Database.Configuration;

namespace Mvp.Passive.View.Base.Database
{
    public class TestContext : DbContext
    {
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public static Action<string> Log = s => Console.WriteLine("{0:HH:mm:ss.ffff} - {1}", DateTime.Now, s);

        public TestContext() : base("name=TestContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
