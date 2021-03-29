using System;
using System.Collections.Generic;
using System.Text;
using TripUp.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace TripUp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Private Members

        #endregion

        #region Public Members

        #endregion

        #region Constructors
        /// <summary>
        /// This is main entry to the vm
        /// </summary>
        public MainViewModel()
        {
            PageTitle = "My Trips";

            MostVisited = new ObservableRangeCollection<Countries>
            {
                new Countries{Country="Russia",Uri="tour-1.jpg", Date="Jul 5 - Jul 15"},
                new Countries{Country="Austria",Uri="tour-2.jpg", Date="Jul 17 - Jul 21"},
                new Countries{Country="UK",Uri="tour-3.jpg", Date="Jun 9 - Jul 22"},
                new Countries{Country="Taiwan",Uri="tour-4.jpg", Date="Aug 19 - Aug 31"},
                new Countries{Country="Morocco",Uri="tour-5.jpg", Date="Sep 8 - Sep 19"},
                new Countries{Country="Mexico",Uri="tour-6.jpg", Date="Oct 2 - Oct 12"},
                new Countries{Country="Egypt",Uri="tour-7.jpg", Date="Nov 8 - Nov 19"},
                new Countries{Country="Peru",Uri="tour-8.jpg", Date="Dec 20 - Dec 31"},

            };
        }
        #endregion

        #region Helper Methods
        #endregion

    }
}
