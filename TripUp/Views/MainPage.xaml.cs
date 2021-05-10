using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripUp.ViewModels;
using Xamarin.Forms;

namespace TripUp.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel(this);
        }
    }
}
