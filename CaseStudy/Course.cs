using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Course:IEnrollable
    {
        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public void CourseRegistration(Student student, Course course)
        {
            EnrollmentRecord enroll = new EnrollmentRecord(student, course);
            int count = 10;
            if (count <= 10)
            {
                EnrollmentRecord stud = EnrollmentRecord.EnrollmentRecords.FirstOrDefault(s => s.Student.Name == student.Name);
                if (stud == null)
                {
                    EnrollmentRecord.EnrollmentRecords.Add(enroll);
                }
                else
                {
                    throw new EnrollmentException("Student Already Exists");
                }
            }
            else
            {
                throw new EnrollmentException("No seats available.Course is full.");
            }
        }

        public void CourseWithdrawal(EnrollmentRecord enrollrec)
        {
            EnrollmentRecord stud = EnrollmentRecord.EnrollmentRecords.FirstOrDefault(s => s.Student.StudentId == enrollrec.Student.StudentId);
            if (stud != null)
            {
                EnrollmentRecord.EnrollmentRecords.Remove(stud);
            }
            else
            {
                throw new EnrollmentException("couldnot find student");
            }
        }

      
    }
     


}
