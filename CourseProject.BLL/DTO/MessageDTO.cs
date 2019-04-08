using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.BLL.DTO
{
    class MessageDTO
    {
        public int Id { get; set; }
        public int? User1 { get; set; }
        public int? User2 { get; set; }
        public string Text { get; set; }
    }
}
