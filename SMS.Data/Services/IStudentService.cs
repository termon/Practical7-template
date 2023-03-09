
using SMS.Data.Entities;
	
namespace SMS.Data.Services;

// This interface describes the operations that a StudentService class should implement
public interface IStudentService
{
    // Initialise the repository (database)  
    void Initialise();
    
    // ---------------- Student Management --------------
    List<Student> GetStudents();
    Student GetStudent(int id);
    //Student AddStudent(string name, string course, string email, int age, double grade);
    Student AddStudent(Student s);
    Student UpdateStudent(Student updated);  
    bool DeleteStudent(int id);

    // new interface method
    Student GetStudentByEmail(string email);
}
    
