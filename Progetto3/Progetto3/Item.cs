using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto3
{
    [Table("Item")]
    public class Item 
    {
        [PrimaryKey]
        [Column("id")]
        public int id { get; set; }
        [Column("Value")]
        public int value { get; set; }
    }

    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
    }
}
