namespace Mvp.Passive.View.Base.Model.IRepository
{
    public interface IApplicationRepository
    {
        IGroupRepository Group { get; set; }

        IUserRepository User { get; set; }
    }
}
