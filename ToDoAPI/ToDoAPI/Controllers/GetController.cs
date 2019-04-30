using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ToDoAPI.Infrastructure.DataSources;

namespace ToDoAPI.Controllers
{
    /// <summary>
    /// The controller that handles get requests for all of the todo items
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        #region Properties
        /// <summary>
        /// The to do data source. This is where we'll pull our todo data from
        /// </summary>
        public ToDoDataSource _ToDoData { get; set; }
        #endregion

        public GetController(ToDoDataSource dataSource)
        {
            _ToDoData = dataSource;
        }

        /// <summary>
        /// Gets all of the todos that match the passed in ID
        /// </summary>
        /// <param name="toDoID">The ID of the to do to get</param>
        /// <returns></returns>
        [Route("todos/")]
        [Route("todos/{toDoID}")]
        [EnableCors("AllowOrigin")]
        public async Task<JsonResult> ToDos(int? toDoID) =>
            new JsonResult(await _ToDoData.GetToDos(toDoID));
    }
}