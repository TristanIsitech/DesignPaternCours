using System.ComponentModel.DataAnnotations.Schema;

public class Bibliotheque
{
    public List<Livre> livres = new List<Livre>();
    public List<Auteur> auteurs = new List<Auteur>();

    public List<Client> clients = new List<Client>();
    public List<Livre> SuivreAuteur(Auteur auteur)
    {
        List<Livre> livreDunAuteur = new List<Livre>();
        foreach (Livre unLivre in livres)
        {
            if (unLivre.auteur.nom == auteur.nom)
            {
                livreDunAuteur.Add(unLivre);
            }
        }
        return livreDunAuteur;
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

    public void AjouterLivre(string titre, Auteur auteur, Categories categories, decimal prix)
    {
        livres.Add(livreBuilder.AjouterLivre(titre, auteur, categories, prix));
    }
    public void AjouterAuteur(string nom)
    {
        auteurs.Add(auteurBuilder.AjouterAuteur(nom));
    }

    public void AjouterEtudiant(string nom, decimal portfeuil)
    {
        clients.Add(new Etudiant(nom, portfeuil));
    }
    public void AjouteurAdulte(string nom, decimal portfeuil)
    {
        clients.Add(new Adulte(nom, portfeuil));
    }
    public void AjouterSenior(string nom, decimal portfeuil)
    {
        clients.Add(new Senior(nom, portfeuil));
    }
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