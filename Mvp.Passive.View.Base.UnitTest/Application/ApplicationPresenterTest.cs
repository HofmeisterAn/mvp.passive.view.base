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
            Assert.That(string.IsNullOrEmpty(this.mockApplicationView.FirstName), Is.False, "First name ist null or empty.");
            Assert.That(string.IsNullOrEmpty(this.mockApplicationView.Surname), Is.False, "Surname ist null or empty.");
        }
    }
}
