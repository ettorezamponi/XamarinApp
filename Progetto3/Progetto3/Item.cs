using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto3
{
    [Table("Umbrella")]
    public class Item 
    {
        [PrimaryKey,AutoIncrement]
        [Column("id")]
        public int id { get; set; }
        [Column("Value")]
        public Boolean value { get; set; }
    }
}
