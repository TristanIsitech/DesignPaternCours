public abstract class Client
{
    public string nom { get; set; }
    public MaList<Livre> livres { get; set; } = new MaList<Livre>();
    public decimal portfeuil { get; set; }
    public Client(string nom, decimal portfeuil)
    {
        this.nom = nom;
        this.portfeuil = portfeuil;
    }
    public abstract int getReduction();
    public void Empunter(Livre livre)
    {
        portfeuil -= livre.prix - livre.prix * getReduction() / 100;
        livres.Add(livre);
    }
}

public class Etudiant : Client
{
    public Etudiant(string nom, decimal portfeuil) : base(nom, portfeuil)
    {
        this.nom = nom;
        this.portfeuil = portfeuil;
    }
    public override int getReduction()
    {
        return 30;
    }
}

public class Adulte : Client
{
    public Adulte(string nom, decimal portfeuil) : base(nom, portfeuil)
    {
        this.nom = nom;
        this.portfeuil = portfeuil;
    }
    public override int getReduction()
    {
        return 0;
    }
}

public class Senior : Client
{
    public Senior(string nom, decimal portfeuil) : base(nom, portfeuil)
    {
        this.nom = nom;
        this.portfeuil = portfeuil;
    }
    public override int getReduction()
    {
        return 20;
    }
}