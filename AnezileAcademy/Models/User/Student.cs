using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnezileAcademy.Models.User
{
    public class Student : ApplicationUser
    {
        public string StudentID { get; set; }
    }
}
