namespace Mvp.Passive.View.Base.Main.View.Application
{
    public interface IUserApplicationView
    {
        long UserId { get; set; }

        string FirstName { get; set; }

        string Surname { get; set; }

        int GroupCount { get; set; }
    }
}
