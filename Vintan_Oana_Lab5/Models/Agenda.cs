using System;
using SQLite;

namespace Vintan_Oana_Lab5.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
