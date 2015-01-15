using System.Collections.Generic;
using System.Linq;
using Mvp.Passive.View.Base.Model;
using Mvp.Passive.View.Base.Model.IRepository;

namespace Mvp.Passive.View.Base.Database.Repository
{
    public class GroupRepository : IGroupRepository
    {
        public IEnumerable<Group> FindAll()
        {
            using (var testContext = new TestContext())
            {
                return testContext.Groups.ToList();
            }
        }

        public Group FindById(long id)
        {
            using (var testContext = new TestContext())
            {
                return testContext.Groups.SingleOrDefault(x => x.Id == id);
            }
        }
    }
}
