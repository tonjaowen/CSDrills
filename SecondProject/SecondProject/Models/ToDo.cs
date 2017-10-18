using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    public class ToDo

    {
        public int ToDoId { get; set; }

        [Required(ErrorMessage = "You can't create an empty todo item!")]
        
       
        public string Description { get; set; }

        public bool Completed { get; set; }
    }
}
