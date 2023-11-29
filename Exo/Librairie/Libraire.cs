public class Libraire
{
    public string nom;

    public Bibliotheque bibliotheque = new BibliothequeDecorator();
    public Libraire(string nom)
    {
        this.nom = nom;
    }
}