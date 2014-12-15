using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Xamarin.Forms;

namespace RxTabNavTest
{
    public partial class FirstView : ContentPage , IViewFor<FirstViewModel>
    {
        public static readonly BindableProperty ViewModelProperty =
            BindableProperty.Create<FirstView, FirstViewModel>(x => x.ViewModel, default(FirstViewModel));

        public FirstView()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.ViewModel)
                .Subscribe(x => this.BindingContext = x);
        }

        object IViewFor.ViewModel {
            get { return ViewModel; }
            set { ViewModel = (FirstViewModel)value; }
        }

        public FirstViewModel ViewModel
        {
            get { return (FirstViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
    }
}
