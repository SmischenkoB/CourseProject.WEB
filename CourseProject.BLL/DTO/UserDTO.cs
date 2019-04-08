using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.BLL.DTO
{
    class UserDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public int? InfoId { get; set; }
        public int? MessageId { get; set; }
    }
}
