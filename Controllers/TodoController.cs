using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Models;

namespace WebAPIApplication.Controllers
{
    [Route("api/my")]
    public class TodoController : Controller
    {
        public TodoController(ITodoRepository todoItems)
        {
            TodoItems = todoItems;
        }
        public ITodoRepository TodoItems { get; set; }

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return TodoItems.GetAll();
        }
        /*[HttpPost]
        public int AddSum([FromBody] TodoItem item)
        {
           return CreatedAtRoute();
           //test
        }*/

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            var item = TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            TodoItems.Add(item);
            TodoItems.AddSum(item);
            return CreatedAtRoute("GetTodo", new { id = item.Key }, item);
        }
        [Route("Product")]
        [HttpGet]
        public string Product(int a, int b)
        {
            string result = Calculate.Multiply(a,b).ToString();
            return result;
            //yay
        }

    }
}