using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaraMonteiro_s00185743
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem {get; set;}
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public virtual List<Phone> Phones { get; set; }
    }

    public class PhoneData : DbContext
    {

        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
        
        
    }


}
