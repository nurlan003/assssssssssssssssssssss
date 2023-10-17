using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public abstract class BaseEntity
    {


        public int ID { get; set; }

        public DateTime CreatedDate = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }


    }
}
