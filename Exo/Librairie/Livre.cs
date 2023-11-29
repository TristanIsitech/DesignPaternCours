public class Livre
{
    public string titre { get; set; }
    public Categories categories { get; set; }
    public Auteur auteur { get; set; }
    public decimal prix { get; set; }
    public Livre(string titre, Categories categories, Auteur auteur, decimal prix)
    {
        this.titre = titre;
        this.categories = categories;
        this.auteur = auteur;
        this.prix = prix;
    }

    public override string ToString()
    {
        return "'" + titre + "' (" + categories + ") de " + auteur.nom + " à " + prix + "€";
    }
    public string ToJson()
    {
        return "{ \"titre\":" + titre + ", \"Categories\":" + categories + ",\"Auteur\":" + auteur + ",\"decimal\":" + prix + "}";
    }
}

public class LivreBuilder
{
    public Livre AjouterLivre(string titre, Auteur auteur, Categories categories, decimal prix)
    {
        return new Livre(titre, categories, auteur, prix);
    }
}
