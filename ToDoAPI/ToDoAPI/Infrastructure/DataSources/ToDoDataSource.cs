using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Infrastructure.DataModels;

namespace ToDoAPI.Infrastructure.DataSources
{
    /// <summary>
    /// This class represents a todo data source
    /// </summary>
    public class ToDoDataSource
    {
        /// <summary>
        /// A pretend data source that has a list of known todos
        /// </summary>
        public IEnumerable<ToDo> KnownToDos { get; set; } = new List<ToDo>()
        {
            new ToDo() { ID = 1, Title = "Take out the trash", Description = "Take trash out of trash can still in the bag. Then tie up the trash bag and throw it into the trash can outside", TimeAdded = DateTime.Now.AddDays(-21) },
            new ToDo() { ID = 2, Title = "Feed dogs", Description = "TakePour dog food into dog's bowl", TimeAdded = DateTime.Now.AddDays(-13) },
            new ToDo() { ID = 3, Title = "Mow Lawn", Description = "Start up the lawn mower and mow the front and back lawns", TimeAdded = DateTime.Now.AddDays(-1) },
            new ToDo() { ID = 4, Title = "Buy wife some pretty flowers", Description = "Go to the most expensive flower store I can think of and purchase lilys for the wife. Make sure to pay AT LEAST 100 dollars.", TimeAdded = DateTime.Now },
            new ToDo() { ID = 5, Title = "Stop eating junk food", Description = "Stop eating crap. Just put it down....", TimeAdded = DateTime.Now.AddDays(-75) },
        };                     

        /// <summary>
        /// Retrieves the list of known todos
        /// </summary>
        /// <returns>An IEnumerable of a todo list</returns>
        public async Task<IEnumerable<ToDo>> GetToDos(int? toDoID) => 
            await Task.Run(() => 
                KnownToDos
                .Where(m => m.ID == (toDoID ?? m.ID))
            );
    }
}
