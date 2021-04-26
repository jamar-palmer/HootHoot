using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HootHootLibrary
{
    public class Course
    {

        private string subject;
        private string semester;
        private string college;
        private string campus;
        private string instructor;
        private int crn;
        private int section;
        private double credithours;
        private DateTime meetingtime;
        private int capacity;

        public String Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public String Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public String College
        {
            get { return college; }
            set { college = value; }
        }
        public String Campus
        {
            get { return campus; }
            set { campus = value; }
        }
        public String Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        public int CRN
        {
            get { return crn; }
            set { crn = value; }
        }
        public int Section
        {
            get { return section; }
            set { section = value; }
        }
        public double Credithours
        {
            get { return credithours; }
            set { credithours = value; }
        }
        public DateTime Meetingtime
        {
            get { return meetingtime; }
            set { meetingtime = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

    }
}
