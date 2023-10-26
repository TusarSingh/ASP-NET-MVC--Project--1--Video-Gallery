using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string MovieType { get; set; }

        public DateTime ReleasedDate { get; set; }

        public DateTime AddDate { get; set; }

        public int NumberOfStock { get; set; }
    }
}