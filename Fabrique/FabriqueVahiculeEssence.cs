public class FabriqueVehiculeEssence: FabriqueVehicule{
    public Voiture creerAutomobile()
    {
        return new VoitureEssence();
    }

    public Scooter creerScooter()
    {
        return new ScooterEssence();
    }
}