using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Models.View
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDoItem> Items { get; set; }
    }
}
