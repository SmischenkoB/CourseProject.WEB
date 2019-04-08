using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Entenies
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public int? InfoId { get; set; }   
       
        public virtual ICollection<Message> Messages { get; set; }
        public virtual Info Info { get; set; }

        public User()
        {           
            Messages = new List<Message>();
        }
    }
}
