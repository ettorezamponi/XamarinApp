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

    [Table("Recensione")]
    public class Recensione
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int id { get; set; }
        [Column("Description")]
        public string description { get; set; }
    }

}