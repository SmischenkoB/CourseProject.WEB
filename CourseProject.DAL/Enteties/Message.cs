using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Entenies
{
    public class Message
    {
        public int Id { get; set; }

        public int User1 { get; set; } 
        
        public int User2 { get; set; }

        public string Text { get; set; }
         
        public virtual User User { get; set; }

       
    }
}
