using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectIdea
{
    public class Project
    {
        private string name;
        private string manager;
        private string Description;
        private List<Member> Members;
        private List<string> FunctionalRequirements;
        private List<string> NonFunctionalRequirements;
        private List<Risk> Risks;

        public string Name { get => name; set => name = value; }
        public string Manager { get => manager; set => manager = value; }
        public string Description1 { get => Description; set => Description = value; }
        public List<Member> Members1 { get => Members; set => Members = value; }
        public List<string> FunctionalRequirements1 { get => FunctionalRequirements; set => FunctionalRequirements = value; }
        public List<string> NonFunctionalRequirements1 { get => NonFunctionalRequirements; set => NonFunctionalRequirements = value; }
        public List<Risk> Risks1 { get => Risks; set => Risks = value; }

        public Project(string Name)
        {
            this.Name = Name;
            this.Members1 = new List<Member>();
            this.FunctionalRequirements1 = new List<string>();
            this.NonFunctionalRequirements1 = new List<string>();
            this.Risks1 = new List<Risk>();
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
            return this.Description1;
        }

        public List<Member> GetMembers()
        {
            return this.Members1;
        }

        public List<string> GetFunctionalRequirements()
        {
            return this.FunctionalRequirements1;
        }

        public List<string> GetNonFunctionalRequirements()
        {
            return this.NonFunctionalRequirements1;
        }

        public List<Risk> GetRisks()
        {
            return this.Risks1;
        }

        public void SetName(string newName)
        {
            this.Name = newName;
        }

        public void SetDescription(string newDescription)
        {
            this.Description1 = newDescription;
        }


        public void AddMember(Member Member)
        {
            this.Members1.Add(Member);
        }

        public void AddFunctionalRequirement(string FuncReq)
        {
            this.FunctionalRequirements1.Add(FuncReq);
        }

        public void AddNonFunctionalRequirement(string NonFuncReq)
        {
            this.NonFunctionalRequirements1.Add(NonFuncReq);
        }

        public void AddRisk(Risk Risk)
        {
            this.Risks1.Add(Risk);
        }

        public void RemoveMember(Member Member)
        {
            this.Members1.Remove(Member);
        }

        public void RemoveFunctionalRequirement(string FuncReq)
        {
            this.FunctionalRequirements1.Remove(FuncReq);
        }

        public void RemoveNonFunctionalRequirement(string NonFuncReq)
        {
            this.NonFunctionalRequirements1.Remove(NonFuncReq);
        }

        public void RemoveRisk(Risk Risk)
        {
            this.Risks1.Remove(Risk);
        }

    }


}