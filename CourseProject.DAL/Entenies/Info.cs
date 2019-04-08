using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Entenies
{
    public class Info
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
