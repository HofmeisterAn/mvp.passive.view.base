using System.Collections.Generic;

namespace Mvp.Passive.View.Base.Model
{
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
