using System;
using System.ComponentModel.DataAnnotations;

namespace SMS.Data.Entities;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Course { get; set; }

    public int Age { get; set; } 

    public double Grade { get; set; }

    public string PhotoUrl { get; set; }     

    // Read-Only property - not stored in database
    public string Classification => Classify();

    // private method to calculate the classification
    private string Classify() 
    {
        if (Grade < 50)
        {
            return "Fail";
        }
        else if (Grade >=50 && Grade < 70)
        {
            return "Pass";
        }
        else if (Grade >=70 && Grade < 80)
        {
            return "Commendation";
        }
        else
        {
            return "Distinction";
        }
    }

}
