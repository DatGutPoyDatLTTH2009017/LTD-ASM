using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTD_Asm.Controllers
{
    public class Student
    {
        public int MaSinhVien { get; set; }
        public string Fines { get; set; }
        public int Money { get; set; }
        public DateTime Penalty {
            get { return DateTime.Now; }
        }
    }
}