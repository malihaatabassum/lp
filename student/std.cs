
using System;
using System.Collections.Generic;
using System.Text;

namespace lp3
{
    class def
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Maliha";
            s1.Id = "11223344";
            s1.Department = "CSE";
            s1.Cgpa = 3.33f;
            s1.showInfo();
        }
    }
}
