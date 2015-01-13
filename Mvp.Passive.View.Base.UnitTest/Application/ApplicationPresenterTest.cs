using Mvp.Passive.View.Base.Main.Presenter;
using NUnit.Framework;

namespace Mvp.Passive.View.Base.UnitTest.Application
{
    [TestFixture]
    public class ApplicationPresenterTest
    {
        private readonly MockApplicationView mockApplicationView;

        private readonly MockApplicationRepository mockApplicationRepository;

        private readonly ApplicationPresenter applicationPresenter;

        public ApplicationPresenterTest()
        {
            this.mockApplicationRepository = new MockApplicationRepository();
            this.mockApplicationView = new MockApplicationView();
            this.applicationPresenter = new ApplicationPresenter(this.mockApplicationView, this.mockApplicationRepository);
        }

        [Test]
        public void IsViewInitializing()
        {
            Assert.That(this.mockApplicationView.FirstName.Length == 0, Is.False, "First name is null or empty.");
            Assert.That(this.mockApplicationView.Surname.Length == 0, Is.False, "Surname is null or empty.");
        }
    }
}
