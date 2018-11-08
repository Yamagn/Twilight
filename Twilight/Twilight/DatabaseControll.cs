using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Twilight.Models;

namespace Twilight
{
    public class DatabaseControll
    {
        readonly SQLiteAsyncConnection database;

        public DatabaseControll(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Token>().Wait(); 
        }
        
        public Task<List<Token>> GetItemsAsync()
        {
            return database.Table<Token>().ToListAsync();
        }

        public Task<Token> GetItemAsync(int id)
        {
            return database.Table<Token>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Token item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Token item)
        {
            return database.DeleteAsync(item);
        }
    }
}