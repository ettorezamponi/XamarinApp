using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto3
{
    public class Item
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength (50)]
        public string Description { get; set; }
    }

    
}
