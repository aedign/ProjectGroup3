using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectIdea
{
    public class Project
    {
        public string Name;
        public string Manager;
        private string Description;
        private List<Member> Members;
        private List<string> FunctionalRequirements;
        private List<string> NonFunctionalRequirements;
        private List<FormRisk> Risks;

        public Project(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            this.Members = new List<Member>();
            this.FunctionalRequirements = new List<string>();
            this.NonFunctionalRequirements = new List<string>();
            this.Risks = new List<FormRisk>();
        }

        public override string ToString()
        {
            return this.Name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public List<Member> GetMembers()
        {
            return this.Members;
        }

        public List<string> GetFunctionalRequirements()
        {
            return this.FunctionalRequirements;
        }

        public List<string> GetNonFunctionalRequirements()
        {
            return this.NonFunctionalRequirements;
        }

        public List<FormRisk> GetRisks()
        {
           return this.Risks;
        }

        public void SetName(string newName)
        {
            this.Name = newName;
        }

        public void SetDescription(string newDescription)
        {
            this.Description = newDescription;
        }


        public void AddMember(Member Member)
        {
            this.Members.Add(Member);
        }

        public void AddFunctionalRequirement(string FuncReq)
        {
            this.FunctionalRequirements.Add(FuncReq);
        }

        public void AddNonFunctionalRequirement(string NonFuncReq)
        {
            this.FunctionalRequirements.Add(NonFuncReq);
        }

        public void AddRisk(FormRisk Risk)
        {
            this.Risks.Add(Risk);
        }

        public void RemoveMember(Member Member)
        {
            this.Members.Remove(Member);
        }

        public void RemoveFunctionalRequirement(string FuncReq)
        {
            this.FunctionalRequirements.Remove(FuncReq);
        }

        public void RemoveNonFunctionalRequirement(string NonFuncReq)
        {
            this.NonFunctionalRequirements.Remove(NonFuncReq);
        }

        public void RemoveRisk(FormRisk Risk)
        {
            this.Risks.Remove(Risk);
        }

    }

    
}