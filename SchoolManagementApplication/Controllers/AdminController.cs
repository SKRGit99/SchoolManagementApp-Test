using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult getStudentDetails()
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentDetailsModel> studentDetails = new List<StudentDetailsModel>();
            

            studentDetails = studentDetailsBusiness.GetStudentDetails();

            /*This code is for grtting dropdown details*/
            List<StudentDetailsForDropdown> student = new List<StudentDetailsForDropdown>();
            student = studentDetailsBusiness.GetStudentDetailsForDropdown();
            ViewBag.studentList = new SelectList(student, "student_registration_Id", "student_name");
            /*code for grtting dropdown details ends*/

            return View(studentDetails);
        }

      
    }
}
