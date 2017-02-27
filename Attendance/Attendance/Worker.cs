
using Attendance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance
{
    public class Worker
    {
        Repository _repository = new Repository();

        public void DoWork()
        {
            _repository.AddStudent();
        }
        
    }
}