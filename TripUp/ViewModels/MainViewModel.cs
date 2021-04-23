using System.Threading.Tasks;
using TripUp.Models;
using TripUp.Views;
using Xamarin.CommunityToolkit.ObjectModel;

namespace TripUp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Private Members

        #endregion

        #region Public Members
        /// <summary>
        /// Declaration of move to detail command
        /// </summary>
        public IAsyncCommand<Plans> MoveToDetailCommand { private set; get; }

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

            //The title of the page
            PageTitle = "My Trips";

            MoveToDetailCommand = new AsyncCommand<Plans>(MoveIt);

            //The list of most visited places.
            MostVisited = new ObservableRangeCollection<Countries>
            {
                new Countries{Country="Russia",Uri="tour-1.jpg", Date="Jul 5 - Jul 15"},
                new Countries{Country="Austria",Uri="tour-2.jpg", Date="Jul 17 - Jul 21"},
                new Countries{Country="UK",Uri="tour-3.jpg", Date="Jun 9 - Jul 22"},
                new Countries{Country="Taiwan",Uri="tour-4.jpg", Date="Aug 19 - Aug 31"},
                new Countries{Country="Morocco",Uri="tour-5.jpg", Date="Sep 8 - Sep 19"},
                new Countries{Country="Mexico",Uri="tour-6.jpg", Date="Oct 2 - Oct 12"},
                new Countries{Country="Egypt",Uri="tour-7.jpg", Date="Nov 8 - Nov 19"},
                new Countries{Country="Peru",Uri="tour-8.jpg", Date="Dec 20 - Dec 31"}
            };

            PlannedVisits = new ObservableRangeCollection<Plans>
            {
                new Plans{City="St.Petersburg",Uri="hotel-1.jpg", Date="Jul 5 - Jul 15", Location="Lahm 220, 4420", Phone="+43 660 5521458", Lodge="W&S Executive Apt.", NumberOfDays="10", Cost="2500"},
                new Plans{City="Prague",Uri="hotel-9.jpg", Date="Jul 17 - Jul 21", Location="Supervile 3, 201", Phone="+53 200 5361998", Lodge="Gruben Hotel", NumberOfDays="4", Cost="3500"},
                new Plans{City="Bergen",Uri="hotel-3.jpg", Date="Jun 9 - Jul 22", Location="Contara 102, 774", Phone="+3 300 0014578", Lodge="Fundel Hotel", NumberOfDays="12", Cost="2050"},
                new Plans{City="Istanbul",Uri="hotel-4.jpg", Date="Aug 19 - Aug 31", Location="Yempola 2114, 20", Phone="+53 400 147702", Lodge="Gonjaha Hotel", NumberOfDays="8", Cost="2500"},
                new Plans{City="San Francisco",Uri="hotel-5.jpg", Date="Sep 8 - Sep 19", Location="Crispark 1002, 8954", Phone="+85 500 2030145", Lodge="Mostel Holy Apt.", NumberOfDays="11", Cost="2500"},
                new Plans{City="Kyoto",Uri="hotel-6.jpg", Date="Oct 2 - Oct 12", Location="Kinmil 3088, 7855", Phone="+77 600 6969885", Lodge="Reasosa iddle Hotel", NumberOfDays="10", Cost="1900"},
                new Plans{City="Dubrovnik",Uri="hotel-7.jpg", Date="Nov 8 - Nov 19", Location="Zenda 60, 9900", Phone="+45 700 6980014", Lodge="Assamalin Hotel", NumberOfDays="10", Cost="3000"},
                new Plans{City="Cape Town",Uri="hotel-8.jpg", Date="Dec 20 - Dec 31", Location="Fantom Hall 12, 4458", Phone="+277 010 4205555", Lodge="Mombasa Executive Hotel", NumberOfDays="11", Cost="5000"}
            };

        }

        #endregion

        #region Helper Methods

        private async Task MoveIt(Plans plan)
        {
            await Instance.Navigation.PushAsync(new DetailPage(plan));
        }
        #endregion

    }
}
