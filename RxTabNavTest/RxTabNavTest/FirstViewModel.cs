using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace RxTabNavTest
{
    public class FirstViewModel : ReactiveObject, IRoutableViewModel, IScreen
    {
        public FirstViewModel() {
            UrlPathSegment = "First";
            Router = new RoutingState();
            HostScreen = this;
            MainText = "First View Model";
        }

        public string UrlPathSegment { get; private set; }
        public IScreen HostScreen { get; private set; }
        public RoutingState Router { get; private set; }
        public string MainText { get; set; }
    }
}
