using System;

namespace lp3
{
    public class Course
    {
        String courseName;
        String courseCode;
        int courseCredit;


        public string Name
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string Code;
        {
            set { courseCode= value ; }
    get { return courseCode; }}

public int Credit;
{
    set { courseCredit = value; }
    get { return courseCredit; }
}


public void showInfo()

{
    Console.WriteLine("Course name: " + Name);

    Console.WriteLine("Course code : " + Code);
    Console.WriteLine("Course credit: " + Credit);
}



