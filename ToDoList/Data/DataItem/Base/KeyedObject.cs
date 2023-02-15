using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.DataItem.Base
{
    public abstract class KeyedObject
    {
        [Key]
        public Guid Id { get; set; }
    }
}