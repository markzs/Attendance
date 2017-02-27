using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Attendance.Model
{
    public class Repository
    {
        public void AddStudent()
        {
            using(var context = new Context())
            {
                context.Students.Add(new Student()
                {
                    FirstName = "firstnametest",
                    LastName = "lastnametest",
                    isPresent = true
                });
                context.SaveChanges();
            }
        }
    }
}