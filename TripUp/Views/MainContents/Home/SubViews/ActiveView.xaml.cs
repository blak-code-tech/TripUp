using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripUp.ViewModels.MainContentViewModel.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripUp.Views.MainContents.Home.SubViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActiveView : ContentView
    {
        public ActiveView()
        {
            InitializeComponent();
            BindingContext = new ActiveViewModel();
        }
    }
}