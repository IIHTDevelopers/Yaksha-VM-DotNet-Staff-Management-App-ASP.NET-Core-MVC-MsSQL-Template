using Microsoft.AspNetCore.Mvc;
using StaffManagementApp.DAL.Interface;
using StaffManagementApp.Models;

namespace StaffManagementApp.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffInterface _staffRepository;

        public StaffController(IStaffInterface staffRepository)
        {
            _staffRepository = staffRepository;
        }

        // GET: /Staff/Index
        public IActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Staff/Details/{id}
        public IActionResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Staff/Create
        public IActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Staff/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Staff staff)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Staff/Edit/{id}
        public IActionResult Edit(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Staff/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Staff updatedStaff)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Staff/Delete/{id}
        public IActionResult Delete(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Staff/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
