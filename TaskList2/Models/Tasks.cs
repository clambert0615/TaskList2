using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskList2.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Description { get; set; }
       
        public DateTime DueDate { get; set; }
        public bool? Completion { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }

    }
}
