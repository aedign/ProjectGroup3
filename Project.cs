using System.Collections.Generic;

public class Project
{
    private string name;
    private string description;
    private List<string> members;
    private List<string> functionalRequirements;
    private List<string> nonFunctionalRequirements;
    private List<Risk> risks;

    public Project(string name, string description)
    {
        this.name = name;
        this.description = description;
        this.members = new List<string>();
    }

    public string getName()
    {
        return this.name;
    }

    public string getDescription()
    {
        return this.description;
    }

    public List<string> getMembers()
    {
        return this.members;
    }

    public List<string> getFunctionalRequirements()
    {
        return this.functionalRequirements;
    }

    public List<string> getNonFunctionalRequirements()
    {
        return this.nonFunctionalRequirements;
    }

    public List<Risk> getRisks()
    {
        return this.risks;
    }

    public void setName(string newName)
    {
        this.name = newName;
    }

    public void setDescription(string newDescription)
    {
        this.description = newDescription;
    }

    public void addMember(string name)
    {
        this.members.Add(name);
    }

    public void addFunctionalRequirement(string funcReq)
    {
        this.functionalRequirements.Add(funcReq);
    }

    public void addNonFunctionalRequirement(string nonFuncReq)
    {
        this.functionalRequirements.Add(nonFuncReq);
    }

    public void addRisk(Risk risk)
    {
        this.risks.Add(risk);
    }

    public void removeMember(string member)
    {
        this.members.Remove(member);
    }
}