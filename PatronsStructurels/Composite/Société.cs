using System.Diagnostics.Contracts;

public class Société
{
    public string name;
    public int nbVehicules;
    public Société(string name, int nbVehicules)
    {
        this.name = name;
        this.nbVehicules = nbVehicules;
    }
    public List<Société> childs = new List<Société>();
    public void AddSociétéChilds(Société newChild)
    {
        childs.Add(newChild);
    }

    public int GetNbVehicules()
    {
        int results = nbVehicules;
        foreach (Société aChilds in childs)
        {
            results += aChilds.GetNbVehicules();
        }
        return results;
    }

    public string GetCalculInText()
    {
        if (childs.Count >= 1)
        {
            string results = this.GetNbVehicules().ToString() + " = (" + name + ") " + nbVehicules.ToString();
            foreach (Société aChilds in childs)
            {
                results += " + " + aChilds.GetCalculInText();
            }
            return results;
        }
        else
        {
            return "(" + name + ") " + nbVehicules.ToString();
        }
    }
}