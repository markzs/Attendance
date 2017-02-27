using Attendance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Svc
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker _worker = new Worker();
            _worker.DoWork();
        }
    }
}
