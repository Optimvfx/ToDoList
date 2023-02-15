using System.ComponentModel.DataAnnotations;
using ToDoList.Data.DataItem;
using ToDoList.Models.Base;

namespace ToDoList.Models
{
    public class TaskInput : IInput<TaskItem>
    {
        [Required]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "The Title must be at less {0} and at max {1} char long.")]  
        public string Title { get; set; }

        
        [StringLength(1000, ErrorMessage = "The Title description must be at max {0} char long.")]  
        public string Description { get; set; }

        public TaskItem ConvertToBaseValue()
        {
            return new TaskItem(Title, Description);
        }
    }
}