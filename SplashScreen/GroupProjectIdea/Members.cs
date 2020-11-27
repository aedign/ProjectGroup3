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
        private RiskStatus status;

        public Risk(string description, RiskStatus status)
        {
            this.name = description;
            this.status = status;
        }

        public string getDescription()
        {
            return this.name;
        }

        public string getStatus()
        {
            return this.status.ToString();
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public void setProbability(RiskStatus newProbability)
        {
            this.status = newProbability;
        }
    }

    public enum RiskStatus
    {
        low,
        mediumLow,
        mediumHigh,
        High,
    }
}