using System.Text.Json;

public static class GestionBDD
{
    public static string path = @"./bdd/";

    public static MaList<Auteur> GetAuteurs()
    {
        MaList<Auteur> lesAuteursBDD = new MaList<Auteur>();
        // On récupère les auteurs
        using (StreamReader reader = new StreamReader(path + "auteurs.json"))
        {
            string json = reader.ReadToEnd();
            if (JsonSerializer.Deserialize<MaList<Auteur>>(json) is not null)
            {
                foreach (Auteur unAuteurBDD in JsonSerializer.Deserialize<MaList<Auteur>>(json)!)
                {
                    lesAuteursBDD.Add(unAuteurBDD);
                }
            }
        }
        return lesAuteursBDD;
    }

    public static void AjoutAuteurs(List<Auteur> lesAuteurs)
    {
        using (StreamWriter writer = new StreamWriter(path + "auteurs.json"))
        {
            Console.WriteLine(JsonSerializer.Serialize(lesAuteurs));
            writer.Write(JsonSerializer.Serialize(lesAuteurs));
        }
    }

    public static MaList<Livre> GetLivres()
    {
        MaList<Livre> lesLivresBDD = new MaList<Livre>();
        // On récupère les auteurs
        using (StreamReader reader = new StreamReader(path + "livres.json"))
        {
            string json = reader.ReadToEnd();
            if (JsonSerializer.Deserialize<MaList<Auteur>>(json) is not null)
            {
                foreach (Livre unLivreBDD in JsonSerializer.Deserialize<MaList<Livre>>(json)!)
                {
                    lesLivresBDD.Add(unLivreBDD);
                }
            }
        }
        return lesLivresBDD;
    }
}