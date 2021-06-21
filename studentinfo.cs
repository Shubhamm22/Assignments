using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class studentinfo
    {
        private string id;
        private string name;
        private int marks;
        public string GetId() { return this.id; }
        public string GetName() { return this.name; }
        public int Getmarks() { return this.marks; }
        public void setid(string value) { this.id = value; }
        public void setname(string value) { this.name = value; }
        public void setmarks(int value) { this.marks = value; }
    }
}
