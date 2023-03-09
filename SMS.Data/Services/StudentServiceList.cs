
using SMS.Data.Entities;

namespace SMS.Data.Services;

public class StudentServiceList : IStudentService
{
    private readonly List<Student> Students;

    public StudentServiceList()
    {
        Students = new List<Student>();
    }

    public void Initialise()
    {
        Students.Clear(); // delete all students from list
    }

    // ------------------ Student Related Operations ------------------------

    // retrieve list of Students
    public List<Student> GetStudents()
    {
        return Students;
    }


    // Retrive student by Id 
    public Student GetStudent(int id)
    {
        return Students.FirstOrDefault(s => s.Id == id);
    }

    // Add a new student checking a student with same email does not exist
    public Student AddStudent(Student student)
    {
        // replace with call to new service method to retrieve student by email
        //var existing = Students.FirstOrDefault(s => s.Email == email);
        var existing = GetStudentByEmail(student.Email);
        if (existing != null)
        {
            return null;
        } 
        // verify grade is valid
        if (student.Grade < 0 || student.Grade > 100)
        {
            return null;
        }

        var s = new Student
        {
            // simple mechanism to calculate next Id
            Id = Students.Count + 1,
            Name = student.Name,
            Course = student.Course,
            Email = student.Email,
            Age = student.Age,
            Grade = student.Grade
        };
        Students.Add(s);
        return s; // return newly added student
    }

    // Delete the student identified by Id returning true if deleted and false if not found
    public bool DeleteStudent(int id)
    {
        var s = GetStudent(id);
        if (s == null)
        {
            return false;
        }
        Students.Remove(s);
        return true;
    }

    // Update the student with the details in updated 
    public Student UpdateStudent(Student updated)
    {
        // verify the student exists 
        var student = GetStudent(updated.Id);
        if (student == null)
        {
            return null;
        }
        // now verify email is still unique
        var emailExists = GetStudentByEmail(updated.Email);
        if (emailExists != null && emailExists.Id != updated.Id)
        {
            return null;
        }
        // verify grade is valid
        if (updated.Grade < 0 || updated.Grade > 100)
        {
            return null;
        }

        // update the details of the student retrieved and save
        student.Name = updated.Name;
        student.Email = updated.Email;
        student.Course = updated.Course;
        student.Age = updated.Age;
        student.Grade = updated.Grade;
        return student;
    }

    public Student GetStudentByEmail(string email)
    {
        return Students.FirstOrDefault(s => s.Email == email);
    }

}
