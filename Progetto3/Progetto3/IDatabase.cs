using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto3
{
    public interface IDatabase
    {
        SQLiteConnection DBConnect();
    }
}
