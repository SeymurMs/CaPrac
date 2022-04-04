using System;
using System.Collections.Generic;
using System.Text;

namespace CAPrac
{
    class Course
    {
        public List<Student> students = new List<Student>();

        public List<Student> FilterByPoint(int min , int max)
        {

            return students.FindAll(x => min <= x.Point && max >= x.Point);
                   

        }
    }
}
