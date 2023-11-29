public class Auteur
{
    public string nom;
    public Auteur(string nom)
    {
        this.nom = nom;
    }
}

public class AuteurBuilder
{
    public Auteur AjouterAuteur(string nom)
    {
        return new Auteur(nom);
    }
}