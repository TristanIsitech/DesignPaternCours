public abstract class ConstructeurLiasseVehicule {
    public Liasse? liasse;
    public abstract void construitBonDeCommande();
    public abstract void construitDemandeImmatriculation();
    public Liasse resultat(){
        return liasse!;
    }
}