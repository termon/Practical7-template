
using Microsoft.AspNetCore.Mvc;

using SMS.Data.Entities;
using SMS.Data.Services;

namespace SMS.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService svc;

        public StudentController()
        {
            svc = new StudentServiceDb();
        }

        // GET /student
        public IActionResult Index()
        {
            // TBC - load students using service and pass to view
           
            
            return View();
        }

        // GET /student/details/{id}
        public IActionResult Details(int id)
        {
            // retrieve the student with specifed id from the service
            var s = svc.GetStudent(id);

            // TBC check if s is null and return NotFound()
            

            // pass student as parameter to the view
            return View(s);
        }

        // GET: /student/create
        public IActionResult Create()
        {
            // display blank form to create a student
            return View();
        }

        // POST /student/create
        [HttpPost]
        public IActionResult Create(Student s)
        {
            // complete POST action to add student
            if (ModelState.IsValid)
            {
                // TBC call service AddStudent method using data in s
                
                return RedirectToAction(nameof(Index));
            }
            
            // redisplay the form for editing as there are validation errors
            return View(s);
        }

        // GET /student/edit/{id}
        public IActionResult Edit(int id)
        {
            // load the student using the service
            var s = svc.GetStudent(id);

            // TBC check if s is null and return NotFound()
              

            // pass student to view for editing
            return View(s);
        }

        // POST /student/edit/{id}
        [HttpPost]
        public IActionResult Edit(int id, Student s)
        {
            // complete POST action to save student changes
            if (ModelState.IsValid)
            {
                // TBC pass data to service to update
               

                return RedirectToAction(nameof(Index));
            }

            // redisplay the form for editing as validation errors
            return View(s);
        }

        // GET / student/delete/{id}
        public IActionResult Delete(int id)
        {
            // load the student using the service
            var s = svc.GetStudent(id);
            // check the returned student is not null and if so return NotFound()
            if (s == null)
            {
                return NotFound();
            }     
            
            // pass student to view for deletion confirmation
            return View(s);
        }

        // POST /student/delete/{id}
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            // TBC delete student via service
           
            
            // redirect to the index view
            return RedirectToAction(nameof(Index));
        }


    }
}
