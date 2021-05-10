using SQLite;
using System;
using Xamarin.Forms;

namespace TripUp.Models
{
    public class Trip
    {
        /// <summary>
        /// This property represents the unique identification of a trip.
        /// </summary>
        [PrimaryKey]
        public string Id { get; set; }

        /// <summary>
        /// This property represents the name of a country.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// This property represents the name of a country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// This property represents the image uri of a country.
        /// </summary>
        public ImageSource Uri { get; set; }

        /// <summary>
        /// This property represents the available date for visitation.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// This property represents the start date of the trip
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// This property represents the end date of the trip
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// This property represents the address of the for visitation.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// This property represents the hotel, or appartment 
        /// you will lodge.
        /// </summary>
        public string Lodge { get; set; }

        /// <summary>
        /// This property represents the phone number of the
        /// hotel, or appartment you will lodge.
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// This property represents the descriptions of the hotel.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// This property represents the cost for the hotel.
        /// </summary>
        public string Cost { get; set; }
        
        /// <summary>
        /// This property represents the days to be spent at the hotel.
        /// </summary>
        public string NumberOfDays { get; set; }

    }
}
