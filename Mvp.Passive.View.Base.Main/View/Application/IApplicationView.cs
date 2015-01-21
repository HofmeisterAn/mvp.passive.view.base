using Mvp.Passive.View.Base.Main.Presenter;

namespace Mvp.Passive.View.Base.Main.View.Application
{
    public interface IApplicationView : IUserApplicationView
    {
        ApplicationPresenter Presenter { set; }
    }
}
