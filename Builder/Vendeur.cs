public class Vendeur{
    public ConstructeurLiasseVehicule? constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur){
        this.constructeur = constructeur;
    }

    public Liasse construit(){
        Liasse liasse = constructeur!.resultat();
        return liasse;
    }
}