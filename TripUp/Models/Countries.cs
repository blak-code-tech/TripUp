using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TripUp.Models
{
    public class Countries
    {
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
    }
}
