using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterauntManue
{
    class MenuItem
    {

        public String Name { get; set; }
        public int Price { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }

        public String timeString = DateTime.Now.ToString("hh:mm:ss  MM/dd/yy");

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
