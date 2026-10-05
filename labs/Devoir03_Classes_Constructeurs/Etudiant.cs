// Nom : Ahmet Ibrahima Diene
// Numéro étudiant : 300157381
// Cours : INF1083
// Devoir : 03
// Date : 10/04/2026
// Description : Classes, objets et constructeurs en C#

public class Etudiant
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public double Note { get; set; }

    public Etudiant(string nom, int age, double note)
    {
        Nom = nom;
        Age = age;
        Note = note;
    }

    public void AfficherInformations()
    {
        Console.WriteLine($"Nom : {Nom}");
        Console.WriteLine($"Âge : {Age}");
        Console.WriteLine($"Note : {Note}");
    }

    public string Statut()
    {
        if (Note >= 60)
        {
            return "Réussite";
        }
        return "Échec";
    }
}
