using System.Collections.Generic;

public class Risk
{
    private string description;
    private RiskProbability probability;

    public Risk(string description, RiskProbability probability)
    {
        this.description = description;
        this.probability = probability;
    }

    public string getDescription()
    {
        return this.description;
    }

    public string getProbability()
    {
        return this.probability.ToString();
    }

    public void setDescription(string newDescription)
    {
        this.description = newDescription;
    }

    public void setProbability(RiskProbability newProbability)
    {
        this.probability = newProbability;
    }
}