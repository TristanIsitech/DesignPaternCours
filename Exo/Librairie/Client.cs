public abstract class Client
{
    public string nom;
    public Client(string nom)
    {
        this.nom = nom;
    }
    public abstract int getReduction();
}

public class Etudiant : Client
{
    public Etudiant(string nom) : base(nom)
    {
        this.nom = nom;
    }
    public override int getReduction()
    {
        return 30;
    }
}

public class Adulte : Client
{
    public Adulte(string nom) : base(nom)
    {
        this.nom = nom;
    }
    public override int getReduction()
    {
        return 0;
    }
}

public class Senior : Client
{
    public Senior(string nom) : base(nom)
    {
        this.nom = nom;
    }
    public override int getReduction()
    {
        return 20;
    }
}