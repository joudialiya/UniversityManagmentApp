using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
