using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripUp.Models;
using TripUp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripUp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Plans plan)
        {
            InitializeComponent();

            this.BindingContext = new DetailViewModel(this, plan);
        }
    }
}