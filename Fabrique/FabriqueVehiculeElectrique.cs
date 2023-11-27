public class FarbiqueVehiculeElectrique : FabriqueVehicule
{
    public Voiture creerAutomobile()
    {
        return new VoitureElectrique();
    }

    public Scooter creerScooter()
    {
        return new ScooterElectrique();
    }
}