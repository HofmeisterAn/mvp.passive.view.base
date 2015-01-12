using System.Collections.Generic;
using System.Linq;
using Mvp.Passive.View.Base.Model;
using Mvp.Passive.View.Base.Model.Repository;

namespace Mvp.Passive.View.Base.UnitTest.Application
{
    public class MockApplicationRepository : IApplicationRepository
    {
        public class MockGroupRepository : IGroupRepository
        {
            private readonly List<Group> groups = new List<Group> {
                new Group { Name = "Group1", Description = "Nothing" },
                new Group { Name = "Group2", Description = "Nothing" },
                new Group { Name = "Group3", Description = "Nothing" }
            };

            public IEnumerable<Group> FindAll()
            {
                return this.groups;
            }

            public Group FindById(long id)
            {
                return this.groups.ElementAt((int) id);
            }
        }

        public class UserRepository : IUserRepository
        {
            private readonly List<User> users = new List<User> {
                new User { FirstName = "FirstName1", Surname = "Surname1" },
                new User { FirstName = "FirstName2", Surname = "Surname2" },
                new User { FirstName = "FirstName3", Surname = "Surname3" }
            };

            public IEnumerable<User> FindAll()
            {
                return this.users;
            }

            public User FindById(long id)
            {
                return this.users.ElementAt((int)id);
            }
        }

        public IGroupRepository Group { get; set; }

        public IUserRepository User { get; set; }

        public MockApplicationRepository()
        {
            this.Group = new MockGroupRepository();
            this.User = new UserRepository();
        }
    }
}
