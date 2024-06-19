using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Models;

namespace WebAPIDemo
{
    public class StudentSubjectCollection
    {

        public static  StudentSubjectCollection Current = new StudentSubjectCollection();
        public  List<Student> StudentsList;
        public  List<Subject> SubjectsList;


        public StudentSubjectCollection()
        {
            SubjectsList = new List<Subject>()
            {
                new Subject() { Sid = 1,SName = "Telugu"},
                new Subject() { Sid = 2,SName = "Hindi"},
                new Subject() { Sid = 3,SName = "English"},
                new Subject() { Sid = 4,SName = "Maths"},
                new Subject() { Sid = 5,SName = "Science"},
                new Subject() { Sid = 6,SName = "Social"}
            };

            StudentsList = new List<Student>()
            {
                new Student(){Id=10,Name="A",Age=16,Subjects=new List<Subject>(){ new Subject() { Sid = 4,SName = "Maths"},
                new Subject() { Sid = 5,SName = "Science"},
                new Subject() { Sid = 6,SName = "Social"} } },
               
                new Student(){Id=20,Name="B",Age=13,Subjects=new List<Subject>(){ new Subject() { Sid = 4,SName = "Maths"},
                new Subject() { Sid = 5,SName = "Science"},
                new Subject() { Sid = 6,SName = "Social"}  } },
                new Student(){Id=30,Name="C",Age=11,Subjects=new List<Subject>(){ new Subject() { Sid = 4,SName = "Maths"},
                new Subject() { Sid = 5,SName = "Science"},
                new Subject() { Sid = 6,SName = "Social"}  } }
                

            };

           

        }
    }
}
