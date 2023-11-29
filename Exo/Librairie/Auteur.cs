using System.Runtime.CompilerServices;

public class Auteur
{
    public string nom { get; set; }
    public Auteur(string nom)
    {
        this.nom = nom;
    }

    public override string ToString()
    {
        return nom;
    }
}

public class AuteurBuilder
{
    public Auteur AjouterAuteur(string nom)
    {
        return new Auteur(nom);
    }
}