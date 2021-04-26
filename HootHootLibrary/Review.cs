using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HootHootLibrary
{
    public class Review
    {
        private string course;
        private double rating;
        private string rev;

        public String Course
        {
            get { return course; }
            set { course = value; }
        }
        public Double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public String Rev
        {
            get { return rev; }
            set { rev = value; }
        }
    }
}
