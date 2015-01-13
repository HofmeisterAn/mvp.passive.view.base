using System.Collections.Generic;
using System.Linq;
using Mvp.Passive.View.Base.Model;
using Mvp.Passive.View.Base.Model.IRepository;

namespace Mvp.Passive.View.Base.Database.Repository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            using (var testContext = new TestContext())
            {
                return testContext.Users.ToList();
            }
        }

        public User FindById(long id)
        {
            using (var testContext = new TestContext())
            {
                return testContext.Users.Include("Groups").SingleOrDefault(x => x.Id == id);
            }
        }
    }
}
