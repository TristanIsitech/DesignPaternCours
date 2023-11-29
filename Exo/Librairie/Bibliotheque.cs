public class Bibliotheque
{
    public List<Livre> livres = new List<Livre>();
    public List<Auteur> auteurs = new List<Auteur>();
    public List<Livre> SuivreAuteur(string nom)
    {
        return new List<Livre>();
    }

    public List<Livre> SuivreCategorie(Categories categories)
    {
        return new List<Livre>();
    }

    public decimal PrixEmpunt(Livre livre)
    {
        return livre.prix;
    }
}

public class BibliothequeDecorator : Bibliotheque
{
    public LivreBuilder livreBuilder = new LivreBuilder();
    public AuteurBuilder auteurBuilder = new AuteurBuilder();
}

public enum Categories
{
    Roman,
    ScienceFiction,
    Policier,
    Thriller,
    Fantaisie,
    Biographie,
    Histoire,
    Poésie,
    Manga
}