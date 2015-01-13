using System.Collections.Generic;

namespace Mvp.Passive.View.Base.Model.IRepository
{
    /// <summary>
    /// Descirbe the different data accessibilities for the <see cref="User"/> model. The interface provides a low coupling and an easy implementation of other data sources.
    /// In this sample solution the data is provided by a database. The Interface is implemented in the Mvp.Passive.View.Base.Database project.
    /// </summary>
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();

        User FindById(long id);
    }
}
