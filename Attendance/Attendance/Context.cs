using Attendance.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Attendance
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}