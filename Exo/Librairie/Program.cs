// On creer la bibliotheque :
BibliothequeDecorator bibliotheque = new BibliothequeDecorator();

// On creer un libraire pour la bibliotheque :
Libraire leLibraire = new Libraire("Jo", bibliotheque);

// On ajoute un auteur et un livre
leLibraire.bibliothequeDecorator.AjouterAuteur("UnAuteur");
leLibraire.bibliothequeDecorator.AjouterLivre("Un Nouveau Livre", bibliotheque.auteurs[0], Categories.Fantaisie, 12.34m);

// On test si le programme a correctement ajouté notre livre
foreach (Livre unLivre in bibliotheque.livres)
{
    Console.WriteLine(unLivre.ToString());
}
