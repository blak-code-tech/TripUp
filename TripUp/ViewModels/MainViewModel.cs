using System;
using System.Threading.Tasks;
using TripUp.Models;
using TripUp.Views;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TripUp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Private Members
        private DisplayInfo displayInfo = DeviceDisplay.MainDisplayInfo;

        #endregion

        #region Public Members
        /// <summary>
        /// Declaration of move to detail command
        /// </summary>
        public IAsyncCommand<Trip> MoveToDetailCommand { private set; get; }

        /// <summary>
        /// Declaration of Add command
        /// </summary>
        public IAsyncCommand AddCommand { private set; get; }

        /// <summary>
        /// This is an instance of the parent page
        /// </summary>
        public MainPage Instance { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// This is main entry to the vm
        /// </summary>
        public MainViewModel(MainPage page)
        {
            //Set the instance of the mother page
            Instance = page;

            #region AddPopup hide
            
            //Translate AddPopup to hide it
            Instance.AddPopup.TranslationY = displayInfo.Height;

            #endregion

            //The title of the page
            PageTitle = "My Trips";

            MoveToDetailCommand = new AsyncCommand<Trip>(MoveIt);
            AddCommand = new AsyncCommand(AddShow);
            //The list of most visited places.
            ActiveCountries = new ObservableRangeCollection<Countries>
            {
                new Countries{Country="Russia",Uri="tour-1.jpg", Date="May 5 - May 15"},
                new Countries{Country="Austria",Uri="tour-2.jpg", Date="Jul 17 - Jul 21"}
            };
            
            UpcomingCountries = new ObservableRangeCollection<Countries>
            {
                new Countries{Country="UK",Uri="tour-3.jpg", Date="Jun 9 - Jul 22"},
                new Countries{Country="Taiwan",Uri="tour-4.jpg", Date="Aug 19 - Aug 31"},
                new Countries{Country="Morocco",Uri="tour-5.jpg", Date="Sep 8 - Sep 19"}
            };
            
            PastCountries = new ObservableRangeCollection<Countries>
            {
                new Countries{Country="Mexico",Uri="tour-6.jpg", Date="Oct 2 - Oct 12"},
                new Countries{Country="Egypt",Uri="tour-7.jpg", Date="Nov 8 - Nov 19"},
                new Countries{Country="Peru",Uri="tour-8.jpg", Date="Dec 20 - Dec 31"}
            };

            ActiveVisits = new ObservableRangeCollection<Trip>
            {
                new Trip{City="St.Petersburg",Uri="hotel-1.jpg", Date="May 5 - May 15", Location="Lahm 220, 4420", Phone="+43 660 5521458", Lodge="W&S Executive Apt.", NumberOfDays="10", Cost="2500"},
                new Trip{City="Prague",Uri="hotel-9.jpg", Date="May 17 - May 21", Location="Supervile 3, 201", Phone="+53 200 5361998", Lodge="Gruben Hotel", NumberOfDays="4", Cost="3500"},
                new Trip{City="Prague",Uri="image_1.jpg", Date="May 23 - May 30", Location="Long Hase 202", Phone="+70 905 3369852", Lodge="Looken Hotel", NumberOfDays="7", Cost="2850"},
            };

            PastVisits = new ObservableRangeCollection<Trip>
            {
                new Trip{City="Bergen",Uri="hotel-3.jpg", Date="Jan 9 - Jan 22", Location="Contara 102, 774", Phone="+3 300 0014578", Lodge="Fundel Hotel", NumberOfDays="12", Cost="2050"},
                new Trip{City="Istanbul",Uri="hotel-4.jpg", Date="Mar 19 - Mar 31", Location="Yempola 2114, 20", Phone="+53 400 147702", Lodge="Gonjaha Hotel", NumberOfDays="8", Cost="2500"},  
            };

            UpcomingVisits = new ObservableRangeCollection<Trip>
            {
                new Trip{City="San Francisco",Uri="hotel-5.jpg", Date="Sep 8 - Sep 19", Location="Crispark 1002, 8954", Phone="+85 500 2030145", Lodge="Mostel Holy Apt.", NumberOfDays="11", Cost="2500"},
                new Trip{City="Kyoto",Uri="hotel-6.jpg", Date="Oct 2 - Oct 12", Location="Kinmil 3088, 7855", Phone="+77 600 6969885", Lodge="Reasosa iddle Hotel", NumberOfDays="10", Cost="1900"},
                new Trip{City="Dubrovnik",Uri="hotel-7.jpg", Date="Nov 8 - Nov 19", Location="Zenda 60, 9900", Phone="+45 700 6980014", Lodge="Assamalin Hotel", NumberOfDays="10", Cost="3000"},
                new Trip{City="Cape Town",Uri="hotel-8.jpg", Date="Dec 20 - Dec 31", Location="Fantom Hall 12, 4458", Phone="+277 010 4205555", Lodge="Mombasa Executive Hotel", NumberOfDays="11", Cost="5000"}
            };

        }

        #endregion

        #region Helper Methods
        /// <summary>
        /// This method will open the detail page of a trip
        /// </summary>
        /// <param name="plan">This is the plan object..</param>
        /// <returns></returns>
        private async Task MoveIt(Trip trip)
        {
            await Instance.Navigation.PushAsync(new DetailPage(trip));
        }

        /// <summary>
        /// This method shows and hides the add popup..
        /// </summary>
        /// <returns></returns>
        private async Task AddShow()
        {
            if(Instance.AddPopup.TranslationY == displayInfo.Height)
            {
                await Instance.AddPopup.FadeTo(0, 30, Easing.CubicInOut);
                var h = Instance.AddPopup.Height;
                Instance.AddPopupContent.HeightRequest = h * 0.65;
                Instance.AddPopup.IsVisible = true;
                await Task.WhenAll(
                    Instance.AddPopup.TranslateTo(0, 0, 500, Easing.SinInOut),
                    Instance.AddPopup.FadeTo(1, 550, Easing.SinInOut),
                    Instance.AddPopupContent.FadeTo(1, 550, Easing.SinInOut)
                    );
            }
            else
            {
                var y = displayInfo.Height;
                await Task.WhenAll(
                    Instance.AddPopup.TranslateTo(0, y, 500, Easing.SinInOut),
                    Instance.AddPopup.FadeTo(0, 550, Easing.SinInOut),
                    Instance.AddPopupContent.FadeTo(0, 550, Easing.SinInOut)
                    );
            }
        }


        #endregion

    }
}
