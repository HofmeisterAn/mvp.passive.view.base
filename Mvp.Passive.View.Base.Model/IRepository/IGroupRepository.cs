using System.Collections.Generic;

namespace Mvp.Passive.View.Base.Model.IRepository
{
    public interface IGroupRepository
    {
        IEnumerable<Group> FindAll();

        Group FindById(long id);
    }
}
