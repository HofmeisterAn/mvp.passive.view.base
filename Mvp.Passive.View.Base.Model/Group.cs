using System.Collections.Generic;
using Mvp.Passive.View.Base.Model.IRepository;

namespace Mvp.Passive.View.Base.Model
{
    /// <summary>
    /// The <see cref="Group"/> model describe all necessary properties. The accessibility is definced by the <seealso cref="IGroupRepository"/> interface.
    /// </summary>
    public class Group
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Group()
        {
            this.Users = new HashSet<User>();
        }
    }
}
