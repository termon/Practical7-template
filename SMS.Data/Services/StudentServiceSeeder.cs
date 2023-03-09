﻿using SMS.Data.Entities;

namespace SMS.Data.Services;
public static class ServiceSeeder
{
    // use this class to seed the database with dummy test data using an IStudentService 
    public static void Seed(IStudentService svc)
    {
        // wipe and recreate the database
        svc.Initialise();

        // add students
        var s1 = svc.AddStudent( new Student {
            Name = "Homer Simpson", Course = "Physics", Email = "homer@mail.com", Age = 41, Grade = 56, PhotoUrl = "https://static.wikia.nocookie.net/simpsons/images/b/bd/Homer_Simpson.png"
        });
        var s2 = svc.AddStudent( new Student {
            Name = "Marge Simpson", Course = "English", Email = "marge@mail.com", Age = 38, Grade = 69, PhotoUrl = "https://static.wikia.nocookie.net/simpsons/images/4/4d/MargeSimpson.png" 
        });
        var s3 = svc.AddStudent(
            new Student { Name = "Bart Simpson",Course = "Maths", Email = "bart@mail.com", Age = 14, Grade = 61, PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png" 
        });
        var s4 = svc.AddStudent(
            new Student { Name = "Lisa Simpson", Course = "Poetry", Email = "lisa@mail.com", Age = 13, Grade = 80, PhotoUrl = "https://upload.wikimedia.org/wikipedia/en/e/ec/Lisa_Simpson.png" 
        });
        var s5 = svc.AddStudent(
            new Student { Name = "Mr Burns", Course = "Management", Email = "burns@mail.com", Age = 81, Grade = 63, PhotoUrl = "https://static.wikia.nocookie.net/simpsons/images/a/a7/Montgomery_Burns.png" 
        });
        var s6 = svc.AddStudent(
            new Student { Name = "Barney Gumble", Course = "Brewing", Email = "barney@mail.com", Age = 39, Grade = 49, PhotoUrl = "https://static.wikia.nocookie.net/simpsons/images/6/68/Barney_Gumble_-_shading.png" 
        });

        var ok = s1 != null && s2 != null && s3 != null && s4 != null && s5 != null && s6 != null;
        Console.WriteLine($"Seeded data {ok}");
        
    }
}

