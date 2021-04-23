using System.Threading.Tasks;
using System.Windows.Input;
using TripUp.Models;
using TripUp.Views;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace TripUp.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {

        #region Private Members
        /// <summary>
        /// This is an instance of the mother class
        /// </summary>
        private DetailPage Instance { get; set; }

        /// <summary>
        /// This is a refence to the friends list
        /// </summary>
        private ObservableRangeCollection<Friends> friends;

        /// <summary>
        /// This is a refence to the entertainments list
        /// </summary>
        private ObservableRangeCollection<Entertainments> entertainments;

        /// <summary>
        /// This is a refence to the url
        /// </summary>
        private ImageSource uri;

        /// <summary>
        /// This is a refence to the date 
        /// </summary>
        private string date;

        /// <summary>
        /// This is a refence to the city 
        /// </summary>
        private string city;

        /// <summary>
        /// This is a refence to the numberofDays
        /// </summary>
        private string numberofDays;

        /// <summary>
        /// This is a refence to the cost
        /// </summary>
        private string cost;

        #endregion

        #region Public Members
        /// <summary>
        /// A command to move a selected plan to view its details
        /// </summary>
        public IAsyncCommand MoveToMainCommand { private set; get; }

        /// <summary>
        /// This is the FriendsList
        /// </summary>
        public ObservableRangeCollection<Friends> FriendsList
        {
            get { return friends; }
            set { SetProperty(ref friends, value); }
        }

        /// <summary>
        /// This is the EntertainmentList
        /// </summary>
        public ObservableRangeCollection<Entertainments> EntertainmentList
        {
            get { return entertainments; }
            set { SetProperty(ref entertainments, value); }
        }
        
        /// <summary>
        /// This represents the url of the plan
        /// </summary>
        public ImageSource URI
        {
            get { return uri; }
            set { SetProperty(ref uri, value); }
        }
        
        /// <summary>
        /// This represents the date of the plan
        /// </summary>
        public string Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }

        /// <summary>
        /// This represents the City of the plan
        /// </summary>
        public string City
        {
            get { return city; }
            set { SetProperty(ref city, value); }
        }

        /// <summary>
        /// This represents the NumberofDays of the plan
        /// </summary>
        public string NumberOfDays
        {
            get { return numberofDays; }
            set { SetProperty(ref numberofDays, value); }
        }

        /// <summary>
        /// This represents the Cost of the plan
        /// </summary>
        public string Cost
        {
            get { return cost; }
            set { SetProperty(ref cost, value); }
        }

        #endregion

        #region Constructor
        public DetailViewModel(DetailPage page, Plans plan)
        {
            PageTitle = "Detail";

            Instance = page;

            URI = plan.Uri;
            Date = plan.Date;
            City = plan.City;
            Cost = plan.Cost;
            NumberOfDays = plan.NumberOfDays;

            MoveToMainCommand = new AsyncCommand(MoveIt);

            //statusBar.SetDeviceBarColor(Color.Transparent, "one");

            FriendsList = new ObservableRangeCollection<Friends>
            {
                new Friends{Name="Thomas Duvan", Uri="person_1.jpg"},
                new Friends{Name="Charles Kane", Uri="person_2.jpg"},
                new Friends{Name="Robert Venito", Uri="person_3.jpg"}
            };

            EntertainmentList = new ObservableRangeCollection<Entertainments>
            {
                new Entertainments{Name="Boat Riding", Uri="promo-3.jpg"},
                new Entertainments{Name="Cableway", Uri="promo-2.jpg"},
                new Entertainments{Name="Tour", Uri="promo-1.jpg"}
            };
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// This method navigates to the Main Page
        /// </summary>
        private async Task MoveIt()
        {
            await Instance.Navigation.PopAsync();
        }
        #endregion

    }
}
