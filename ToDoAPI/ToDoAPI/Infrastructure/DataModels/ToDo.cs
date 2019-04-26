using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Infrastructure.DataModels
{
    /// <summary>
    /// The class that represents a todo item
    /// </summary>
    public class ToDo
    {
        /// <summary>
        /// The ID of the todo
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The title of the todo item. Shows up in big bold letters on the page
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of the todo item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The time in which the to do item was added
        /// </summary>
        public DateTime TimeAdded { get; set; }
    }
}
