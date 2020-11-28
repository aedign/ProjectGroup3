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
            this.Name = name;
            this.Status = status;
        }

        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }

        public string GetName()
        {
            return this.Name;
        }

        public string GetStatus()
        {
            return this.Status;
        }

        public void SetName(string newName)
        {
            this.Name = newName;
        }

        public void SetStatus(string Status)
        {
            this.Status = Status;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}