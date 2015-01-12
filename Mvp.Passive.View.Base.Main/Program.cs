using System;
using System.Windows.Forms;
using Mvp.Passive.View.Base.Main.Presenter;
using Mvp.Passive.View.Base.Main.Repository;
using Mvp.Passive.View.Base.Main.View.Application;

namespace Mvp.Passive.View.Base.Main
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            var m = new ApplicationRepository();
            var v = new ApplicationView();
            var p = new ApplicationPresenter(v, m);

            Application.Run(v);
        }
    }
}
