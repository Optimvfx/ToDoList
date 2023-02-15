using System.ComponentModel.DataAnnotations;
using ToDoList.Data.DataItem.Base;

namespace ToDoList.Data.DataItem
{
    public class TaskItem : KeyedObject
    {
        [MaxLength(250)]
        [MinLength(5)]
        [Required]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        public TaskItem(string title, string description, bool isCompleted = false)
        {
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
        }
    }
}