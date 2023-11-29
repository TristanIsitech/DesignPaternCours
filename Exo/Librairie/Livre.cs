public class Livre
{
    public string titre;
    public Categories categories;
    public Auteur auteur;
    public decimal prix;
    public Livre(string titre, Categories categories, Auteur auteur, decimal prix)
    {
        this.titre = titre;
        this.categories = categories;
        this.auteur = auteur;
        this.prix = prix;
    }
}

public class LivreBuilder
{
    public Livre AjouterLivre(string titre, Auteur auteur, Categories categories, decimal prix)
    {
        return new Livre(titre, categories, auteur, prix);
    }
}