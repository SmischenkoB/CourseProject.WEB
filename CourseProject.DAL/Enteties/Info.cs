using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Entenies
{
    public class Info
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }

        //public string Phone { get; set; }

        public string City { get; set; }

        public virtual User User { get; set; }
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {   
                return false;
            }
            Info insideObj = (Info)obj; 
            if(this.City == insideObj.City)
            {
                return true;
            }
            return false;
            // TODO: write your implementation of Equals() here
            
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }
    }
}
