namespace Mvp.Passive.View.Base.Model.Repository
{
    public interface IApplicationRepository
    {
        IGroupRepository Group { get; set; }

        IUserRepository User { get; set; }
    }
}
