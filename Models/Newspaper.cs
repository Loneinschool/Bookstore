using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Newspaper : Publication
    {
        public DateTime Date { get; set; }
        public int Pages { get; set; }
    }
}
