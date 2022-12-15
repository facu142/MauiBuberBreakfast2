using MauiBuberBreakfast2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBuberBreakfast2.Services
{
    public class BreakfastService: IBreakfastService
    {
        private SQLiteAsyncConnection _dbConnection;

        public BreakfastService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Breakfast.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<BreakfastModel>();
            }
        }

        public Task<int> AddBreakfast(BreakfastModel breakfastModel)
        {
            return _dbConnection.InsertAsync(breakfastModel);

        }

        public Task<int> DeleteBreakfast(BreakfastModel breakfastModel)
        {
            return _dbConnection.DeleteAsync(breakfastModel);
        }

        public async Task<List<BreakfastModel>> GetBreakfastList()
        {
            var breakfastList = await _dbConnection.Table<BreakfastModel>().ToListAsync();
            return breakfastList;
        }

        public Task<int> UpdateBreakfast(BreakfastModel breakfastModel)
        {
            return _dbConnection.UpdateAsync(breakfastModel);
        }

    }
}
