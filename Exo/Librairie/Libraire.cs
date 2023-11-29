public class Libraire
{
    public string nom;

    public BibliothequeDecorator bibliothequeDecorator;
    public Libraire(string nom, BibliothequeDecorator bibliothequeDecorator)
    {
        this.nom = nom;
        this.bibliothequeDecorator = bibliothequeDecorator;
    }
}