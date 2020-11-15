using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tohatan_Adrian_Lab2.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public PublishedBook Publisher { get; set; }
        public Book Book { get; set; }

    }
}
