using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TripUp.Models;
using TripUp.Services;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace TripUp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        #region Private Members

        private ObservableRangeCollection<Countries> activeCountries;
        private ObservableRangeCollection<Countries> upcomingCountries;
        private ObservableRangeCollection<Countries> pastCountries;

        private string pageTitle;
        private ObservableRangeCollection<Trip> activeVisits;
        private ObservableRangeCollection<Trip> upcomingVisits;
        private ObservableRangeCollection<Trip> pastVisits;
        private bool isBusy;

        #endregion

        #region Public Members
        /// <summary>
        /// This is to get the dependency service for device bar colors.
        /// </summary>
        public IStatusBarChanger statusBar => DependencyService.Get<IStatusBarChanger>();

        /// <summary>
        /// This property is padding set at thickness ten
        /// </summary>
        public Thickness P1 => 10;

        /// <summary>
        /// This property is the default spacing value for the app
        /// </summary>
        public double Spacing => 5;

        /// <summary>
        /// This property will return a list of countries you are visiting.
        /// </summary>
        public ObservableRangeCollection<Countries> ActiveCountries
        {
            get { return activeCountries; }
            set { SetProperty(ref activeCountries, value); }
        }

        /// <summary>
        /// This property will return a list of countries you will be visiting.
        /// </summary>
        public ObservableRangeCollection<Countries> UpcomingCountries
        {
            get { return upcomingCountries; }
            set { SetProperty(ref upcomingCountries, value); }
        }

        /// <summary>
        /// This property will return a list of countries you have visited.
        /// </summary>
        public ObservableRangeCollection<Countries> PastCountries
        {
            get { return pastCountries; }
            set { SetProperty(ref pastCountries, value); }
        }
        
        /// <summary>
        /// This property will return a list of active trips places.
        /// </summary>
        public ObservableRangeCollection<Trip> ActiveVisits
        {
            get { return activeVisits; }
            set { SetProperty(ref activeVisits, value); }
        }

        /// <summary>
        /// This property will return a list of upcoming trips.
        /// </summary>
        public ObservableRangeCollection<Trip> UpcomingVisits
        {
            get { return upcomingVisits; }
            set { SetProperty(ref upcomingVisits, value); }
        }
        
        /// <summary>
        /// This property will return a list of past trips.
        /// </summary>
        public ObservableRangeCollection<Trip> PastVisits
        {
            get { return pastVisits; }
            set { SetProperty(ref pastVisits, value); }
        }

        public string PageTitle
        {
            get { return pageTitle; }
            set { SetProperty(ref pageTitle, value); }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        #endregion

        #region On Property Changed

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #endregion
    }
}
