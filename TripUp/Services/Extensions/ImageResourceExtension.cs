using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripUp.Services.Extensions
{
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        /// <summary>
        /// This property represents the source of the image.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// This will provide the value or image
        /// </summary>
        /// <param name="serviceProvider">null</param>
        /// <returns></returns>
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            //Checking if the source property is null
            if (Source is null)
                //End execution since there is nothing to work on
                return null;

            //Find the bits of the image
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}
