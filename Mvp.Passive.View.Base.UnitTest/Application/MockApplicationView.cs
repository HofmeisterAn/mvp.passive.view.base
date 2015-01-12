using Mvp.Passive.View.Base.Main.Presenter;
using Mvp.Passive.View.Base.Main.View.Application;

namespace Mvp.Passive.View.Base.UnitTest.Application
{
    public class MockApplicationView : IApplicationView
    {
        public ApplicationPresenter Presenter { set; private get; }
        
        public long UserId { get; set; }

        public string FirstName { get; set; }
        
        public string Surname { get; set; }

        public int GroupCount { get; set; }
        
        public void IsWorking(bool isWorking)
        {
            throw new System.NotImplementedException();
        }
    }
}
