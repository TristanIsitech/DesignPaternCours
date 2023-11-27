public interface FabriqueVehiculeEssence: FabriqueVehicule{
    public new Voiture creerAutomobile()
    {
        return new VoitureEssence();
    }

    public new Scooter creerScooter()
    {
        return new ScooterEssence();
    }
}