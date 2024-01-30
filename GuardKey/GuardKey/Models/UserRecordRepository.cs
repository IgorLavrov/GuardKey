using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuardKey.Models
{
    public class UserRecordRepository
    {

        SQLiteConnection database;

        public UserRecordRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<UserRecord>();
        }

        public IEnumerable<UserRecord> GetItems()
        {
            return database.Table<UserRecord>().ToList();
        }

        public UserRecord GetItem(int id)
        {
            return database.Get<UserRecord>(id);
        }

        public int Delete(int id)
        {
            return database.Delete<UserRecord>(id);
        }

        public int SaveItem(UserRecord item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
