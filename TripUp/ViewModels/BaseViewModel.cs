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

        private ObservableRangeCollection<Countries> mostVisited;
        private string pageTitle;
        private ObservableRangeCollection<Plans> plannedVisits;
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
        /// This property will return a list of most visited places.
        /// </summary>
        public ObservableRangeCollection<Countries> MostVisited
        {
            get { return mostVisited; }
            set { SetProperty(ref mostVisited, value); }
        }
        
        /// <summary>
        /// This property will return a list of most visited places.
        /// </summary>
        public ObservableRangeCollection<Plans> PlannedVisits
        {
            get { return plannedVisits; }
            set { SetProperty(ref plannedVisits, value); }
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
