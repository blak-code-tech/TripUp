using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TripUp.Services.Data
{
    public interface IDataStore<T>
    {
        /// <summary>
        /// Initialize the database
        /// </summary>
        /// <returns></returns>
        Task Init();


        /// <summary>
        /// This is interface is to add a trip
        /// </summary>
        /// <param name="trip">This trip object</param>
        /// <returns></returns>
        Task AddTripAsync(T trip);


        /// <summary>
        /// This is interface is to move a trip to the past trip list
        /// </summary>
        /// <param name="trip">This trip object</param>
        /// <returns></returns>
        Task AddCompletedTripAsync(T trip);


        /// <summary>
        /// This is interface is to make a favorite trip
        /// </summary>
        /// <param name="trip">This trip object</param>
        /// <returns></returns>
        Task AddFavoriteItemAsync(T trip);


        /// <summary>
        /// This is interface is to update a trip's info
        /// </summary>
        /// <param name="trip">This trip object</param>
        /// <returns></returns>
        Task UpdateTripAsync(T trip);


        /// <summary>
        /// This is interface is to remove a trip from the list of trips
        /// </summary>
        /// <param name="trip">This trip object</param>
        /// <returns></returns>
        Task DeleteTripAsync(T trip);


        /// <summary>
        /// This is interface is to make a trip recur
        /// </summary>
        /// <param name="trip">This is the trip object</param>
        /// <returns></returns>
        Task ReDoTripAsync(T trip);


        /// <summary>
        /// This is interface is to return an upcoming or active trip
        /// </summary>
        /// <param name="id">The is of the trip</param>
        /// <returns></returns>
        Task<T> GetTripAsync(string id);


        /// <summary>
        /// This is interface is to return a past trip
        /// </summary>
        /// <param name="id">The is of the trip</param>
        /// <returns></returns>
        Task<T> GetCompletedTripAsync(string id);


        /// <summary>
        /// This is interface is to to return all upcoming and active trips
        /// </summary>
        /// <param name="forceRefresh">To force refresh is nescessary</param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);


        /// <summary>
        /// This is interface is to return all favorite trips
        /// </summary>
        /// <param name="forceRefresh">To force refresh is nescessary</param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetFavoriteItemsAsync(bool forceRefresh = false);


        /// <summary>
        /// This is interface is to return all trips that are completed or past
        /// </summary>
        /// <param name="forceRefresh">To force refresh is nescessary</param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetCompletedTripsAsync(bool forceRefresh = false);
    }
}
