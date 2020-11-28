using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectIdea
{
    public class Member
    {
        public string Name { get; set; }
        public Member(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Risk
    {
        private string name;
        private string status;

        public Risk(string name, string status)
        {
            this.name = name;
            this.status = status;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetStatus()
        {
            return this.status.ToString();
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }

        public void SetStatus(string Status)
        {
            this.status = Status;
        }

        public override string ToString()
        {
            return name;
        }
    }
}