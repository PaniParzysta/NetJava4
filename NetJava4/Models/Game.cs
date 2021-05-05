using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

public class Game
{
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataWydania { get; set; }
        public string Gatunek { get; set; }
        public string Platforma { get; set; }
        public decimal Cena { get; set; }
}