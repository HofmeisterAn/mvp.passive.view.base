using System.Collections.Generic;

namespace Mvp.Passive.View.Base.Model.Repository
{
    public interface IGroupRepository
    {
        IEnumerable<Group> FindAll();

        Group FindById(long id);
    }
}
