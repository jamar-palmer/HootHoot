using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HootHootLibrary
{
    class Course
    {

        public string subject { get; set; }
        public string semester { get; set; }
        public string college { get; set; }
        public string campus { get; set; }
        public string instructor { get; set; }
        public int crn { get; set; }
        public int section { get; set; }
        public double credithours { get; set; }
        public DateTime meetingtime { get; set; }
        public int capacity { get; set; }

        public Course (string s, string sm, string co, string ca, string ins, int cr, int se, double ch, DateTime mt, int cap)
        {
            subject = s;
            semester = sm;
            college = co;
            campus = ca;
            instructor = ins;
            crn = cr;
            section = se;
            credithours = ch;
            meetingtime = mt;
            capacity = cap;


        }



    }
}
