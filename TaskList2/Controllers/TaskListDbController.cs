using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskList2.Models;

namespace TaskList2.Controllers
{
    [Authorize]
    public class TaskListDbController : Controller
    {
        private readonly TaskListDbContext _context;
        public TaskListDbController(TaskListDbContext context)
        {
            _context = context;
        }

        public IActionResult TaskIndex(string sort, string searchString)
        {
            
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var thisUsersTasks = _context.Tasks.Where(x => x.UserId == id).ToList();
            if (sort != null)
            {
                if (sort == "DueDate")
                {
                    thisUsersTasks.Sort((x, y) => DateTime.Compare((DateTime)x.DueDate, (DateTime)y.DueDate));
                }
                if (sort == "Completion")
                {
                    thisUsersTasks.OrderBy(x => x.Completion);
                }
            }
            else if(searchString != null)
            {
                thisUsersTasks = thisUsersTasks.Where(x => x.Description.ToLower().Contains(searchString.ToLower())).ToList();
            }
            
            
            return View(thisUsersTasks);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            newTask.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
                return RedirectToAction("TaskIndex");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult UpdateTask(int id)
        {
            Tasks found = _context.Tasks.Find(id);
            return View(found);
        }

        [HttpPost]
        public IActionResult UpdateTask(Tasks newTask)
        {
            Tasks oldTask = _context.Tasks.Find(newTask.Id);

            if (ModelState.IsValid)
            {
                oldTask.Description = newTask.Description;
                oldTask.DueDate = newTask.DueDate;
                oldTask.Completion = newTask.Completion;
                _context.Entry(oldTask).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(oldTask);
                _context.SaveChanges();
            }
            return RedirectToAction("TaskIndex");
        }

        public IActionResult DeleteTask(int id)
        {
            Tasks found = _context.Tasks.Find(id);
            if(found != null)
            {
                _context.Tasks.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("TaskIndex");
        }

    }
}