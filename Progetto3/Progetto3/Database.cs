using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;
using SQLite;
using System.Threading.Tasks;

namespace Progetto3
{
    public class Database
    {
        public static void Riempi()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(folder, "UmbrellaSQLite.db3");
            var database = new SQLite.SQLiteConnection(databasePath);
            database = DependencyService.Get<IDatabase>().DBConnect();

            //Creazione tabella
            database.CreateTable<Item>();
        }

        protected SQLiteConnection database;
        
        public void InsertOmbrelloni(int id,int value)
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
            database.CreateTable<Item>();
            var item = new Item {id=id,value=value };
            database.Insert(item);
        }

        public void Riempi2()
        {
            InsertOmbrelloni(1,0);
            InsertOmbrelloni(2,0);
            InsertOmbrelloni(3, 0);
            InsertOmbrelloni(4, 0);
            InsertOmbrelloni(5, 0);
            InsertOmbrelloni(6, 0);
            InsertOmbrelloni(7, 0);
            InsertOmbrelloni(8, 0);
            InsertOmbrelloni(9, 0);
            InsertOmbrelloni(10, 0);
            InsertOmbrelloni(11, 0);
            InsertOmbrelloni(12, 0);
            InsertOmbrelloni(13, 0);
            InsertOmbrelloni(14, 0);
            InsertOmbrelloni(15, 0);
            InsertOmbrelloni(16, 0);        
        }
    }

    public class TextDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public TextDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Review>().Wait();
        }

        public Task<List<Review>> GetReviewsAsync()
        {
            return _database.Table<Review>().ToListAsync();
        }

        public Task<Review> GetReviewAsync(int id)
        {
            return _database.Table<Review>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveReviewAsync(Review review)
        {
            if (review.ID != 0)
            {
                return _database.UpdateAsync(review);
            }
            else
            {
                return _database.InsertAsync(review);
            }
        }

        public Task<int> DeleteReviewAsync(Review review)
        {
            return _database.DeleteAsync(review);
        }
    }
}
