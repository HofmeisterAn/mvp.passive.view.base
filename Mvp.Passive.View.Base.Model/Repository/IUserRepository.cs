using System.Collections.Generic;

namespace Mvp.Passive.View.Base.Model.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();

        User FindById(long id);
    }
}
