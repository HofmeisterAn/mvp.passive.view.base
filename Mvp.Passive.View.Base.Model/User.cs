using System.Collections.Generic;

namespace Mvp.Passive.View.Base.Model
{
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
