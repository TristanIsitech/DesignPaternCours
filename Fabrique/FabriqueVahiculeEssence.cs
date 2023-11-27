public class FabriqueVehiculeEssence: FabriqueVehicule{
    public Voiture creerVoiture()
    {
        return new VoitureEssence();
    }

    public Scooter creerScooter()
    {
        return new ScooterEssence();
    }
}