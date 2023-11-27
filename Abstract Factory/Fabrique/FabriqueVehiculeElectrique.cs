public class FarbiqueVehiculeElectrique : FabriqueVehicule
{
    public Voiture creerVoiture()
    {
        return new VoitureElectrique();
    }

    public Scooter creerScooter()
    {
        return new ScooterElectrique();
    }
}