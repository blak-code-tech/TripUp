using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TripUp.Models;
using Xamarin.Essentials;

namespace TripUp.Services.Data
{
    public static class DataStore
    {
        static SQLiteAsyncConnection db;

        public static async Task Init()
        {
            if (db != null)
                return;
            
            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "TripsDB.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Trip>();
        }

        public static Task AddCompletedTripAsync(T trip)
        {
            throw new NotImplementedException();
        }

        public static Task AddFavoriteItemAsync(T trip)
        {
            throw new NotImplementedException();
        }

        public static Task AddTripAsync(T trip)
        {
            throw new NotImplementedException();
        }

        public static Task DeleteTripAsync(T trip)
        {
            throw new NotImplementedException();
        }

        public static Task<T> GetCompletedTripAsync(string id)
        {
            throw new NotImplementedException();
        }

        public static Task<IEnumerable<T>> GetCompletedTripsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public static Task<IEnumerable<T>> GetFavoriteItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public static Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public static Task<T> GetTripAsync(string id)
        {
            throw new NotImplementedException();
        }

        public static Task ReDoTripAsync(T trip)
        {
            throw new NotImplementedException();
        }

        public static Task UpdateTripAsync(T trip)
        {
            throw new NotImplementedException();
        }
    }
}
