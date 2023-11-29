using System.ComponentModel.DataAnnotations.Schema;

public class Bibliotheque
{
    public MaList<Livre> livres = new MaList<Livre>();
    public MaList<Auteur> auteurs = new MaList<Auteur>();

    public MaList<Client> clients = new MaList<Client>();
    public MaList<Livre> SuivreAuteur(Auteur auteur)
    {
        MaList<Livre> livreDunAuteur = new MaList<Livre>();
        foreach (Livre unLivre in livres)
        {
            if (unLivre.auteur.nom == auteur.nom)
            {
                livreDunAuteur.Add(unLivre);
            }
        }
        return livreDunAuteur;
    }

    public MaList<Livre> SuivreCategorie(Categories categories)
    {
        return new MaList<Livre>();
    }

    public decimal PrixEmpunt(Livre livre)
    {
        return livre.prix;
    }

    public Client? GetClient(string nom)
    {
        foreach (Client unClient in clients)
        {
            if (unClient.nom.Equals(nom)) return unClient;
        }
        return null;
    }

    public bool EmprunterUnLivre(Client client, Livre livre)
    {
        bool exist = false;
        foreach (Client unClient in clients)
        {
            if (unClient == client)
            {
                unClient.Empunter(livre);
                exist = true;
            }
        }
        livres.Remove(livre);
        return exist;
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

    public void AjouterLivre(Livre livre)
    {
        livres.Add(livreBuilder.AjouterLivre(livre.titre, livre.auteur, livre.categories, livre.prix));
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

public class MaList<T> : List<T>
{
    public new string ToString()
    {
        string result = "";
        foreach (T livre in this)
        {
            result += livre!.ToString() + "\n";
        }
        return result;
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