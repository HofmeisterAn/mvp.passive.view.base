using System.Collections.Generic;
using Mvp.Passive.View.Base.Model.IRepository;

namespace Mvp.Passive.View.Base.Model
{
    /// <summary>
    /// The <see cref="User"/> model describe all necessary properties. The accessibility is definced by the <seealso cref="IUserRepository"/> interface.
    /// </summary>
    public class User
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public User()
        {
            this.Groups = new HashSet<Group>();
        }
    }
}
