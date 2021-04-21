using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TripUp.Models
{
    public class Plans
    {

        /// <summary>
        /// This property represents the name of a country.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// This property represents the image uri of a country.
        /// </summary>
        public ImageSource Uri { get; set; }

        /// <summary>
        /// This property represents the available date for visitation.
        /// </summary>
        public string Date { get; set; }
        
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
