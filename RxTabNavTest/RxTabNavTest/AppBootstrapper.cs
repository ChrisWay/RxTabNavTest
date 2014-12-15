using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace RxTabNavTest
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper() {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
            Locator.CurrentMutable.Register(() => new FirstView(), typeof(IViewFor<FirstViewModel>));
            //Locator.CurrentMutable.Register(() => new FirstView(), typeof(IScreen));
        }
        public RoutingState Router { get; private set; }

        public Page GetMainPage() {
            var tabs = new TabbedPage();
            var firstView = new FirstViewModel();
            var host = new RoutedViewHostTest();
            host.Router = firstView.Router;
            tabs.Children.Add(host);

            host.Router.Navigate.Execute(firstView);

            return tabs;

        }
    }
}
