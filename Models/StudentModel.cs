using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class StudentModel
    {
        [DisplayName("Regestration ")]
        public int Reg_no { get; set; }
        [DisplayName("Phone no.")]
        public string Phone { get; set; }
        [DisplayName("Age")]
        public int Age { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
    }
}
