using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Book
    {
        private String Name;
        private int Bnum;
        private Department dept;
        private String Author;


        public Boolean isEqual(Book other)
        {
            if (!this.Name.Equals(other.Name)) return false;
            if (this.Bnum != other.Bnum) return false;
            if (this.dept != other.dept) return false;
            if (!this.Author.Equals(other.Author)) return false;
            return true;
        }

        public String NAME
        {
            get { return Name; }
            set { Name = value; }
        }
        public int BNUM
        {
            get { return Bnum; }
            set { Bnum = value; }
        }
        public Department DEPT
        {
            get { return dept; }
            set { dept = value; }
        }
        public String AUTHOR
        {
            get { return Author; }
            set { Author = value; }
        }
    }
}
