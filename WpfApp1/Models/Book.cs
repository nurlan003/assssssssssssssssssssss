using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public DateTime YearPress { get; set; }

        public int ThemesId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PressId { get; set; }

        public string Comment { get; set; }
        public int Quantity { get; set; }
    }
}
