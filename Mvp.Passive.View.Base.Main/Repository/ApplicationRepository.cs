using Mvp.Passive.View.Base.Database.Repository;
using Mvp.Passive.View.Base.Model.Repository;

namespace Mvp.Passive.View.Base.Main.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        public IGroupRepository Group { get; set; }

        public IUserRepository User { get; set; }
        
        public ApplicationRepository()
        {
            this.Group = new GroupConfiguration();
            this.User = new UserRepository();
        }
    }
}
