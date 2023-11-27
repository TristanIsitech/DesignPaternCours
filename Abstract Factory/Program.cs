FabriqueVehicule uneFabriqueElectrique = new FarbiqueVehiculeElectrique();
FabriqueVehicule uneFabriqueEssence = new FabriqueVehiculeEssence();

List<Vehicule> lesVehicules = new List<Vehicule>();
lesVehicules.Add(uneFabriqueElectrique.creerVoiture());
lesVehicules.Add(uneFabriqueEssence.creerScooter());

foreach (var unVehicule in lesVehicules)
{
    Console.WriteLine(unVehicule.GetType());
}
