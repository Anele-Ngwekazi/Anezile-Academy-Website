using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnezileAcademy.Models.User
{
    public class Teacher : ApplicationUser
    {
        public List<Student> Students { get; set; }
    }
}
