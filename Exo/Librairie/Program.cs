// On creer la bibliotheque :
BibliothequeDecorator bibliotheque = new BibliothequeDecorator();

// On creer un libraire pour la bibliotheque :
Libraire leLibraire = new Libraire("Jo", bibliotheque);

// On ajoute un auteur et un livre
leLibraire.bibliothequeDecorator.AjouterAuteur("UnAuteur");
leLibraire.bibliothequeDecorator.AjouterLivre("Un Nouveau Livre", bibliotheque.auteurs[0], Categories.Fantaisie, 12.34m);

// On test si le programme a correctement ajouté notre livre :
Console.WriteLine("Les livres de la bibliotheque : ");
foreach (Livre unLivre in bibliotheque.livres)
{
    Console.WriteLine(unLivre.ToString());
}

// On ajout maintenant un nouveau client a la bibliotheque :
leLibraire.bibliothequeDecorator.AjouterSenior("Michelle", 50);

// On stock le nouveau client dans une variable pour l'utiliser plus facilement
Client? Michelle = bibliotheque.GetClient("Michelle");
if (Michelle is not null)
{
    // Se client vas maintenant emprunter un livre :
    bibliotheque.EmprunterUnLivre(Michelle, bibliotheque.livres[0]);

    // On test si le livre a bien ete ajoute, et si la somme a correctement ete deduite :
    Console.WriteLine("\nLes livres de Michelle (" + Michelle.livres.Count() + ") : ");
    foreach (Livre unLivreDeMichelle in Michelle.livres)
    {
        Console.WriteLine(unLivreDeMichelle.ToString());
    }
    Console.WriteLine("Son portfeuil : " + Michelle.portfeuil);

    // Puis on test si le livre a bien été supprimé de la bibliotheque :
    Console.WriteLine("\nLes livres de le bibliotheque (" + bibliotheque.livres.Count() + ") : ");
    foreach (Livre unLivreDeLeBibliotheque in bibliotheque.livres)
    {
        Console.WriteLine(unLivreDeLeBibliotheque.ToString());
    }
}