using Mvp.Passive.View.Base.Database.Repository;
using Mvp.Passive.View.Base.Model.IRepository;

namespace Mvp.Passive.View.Base.Main.Repository
{
    /// <summary>
    /// Summarize the different data models to a single data repository to match the view requirements.
    /// </summary>
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
