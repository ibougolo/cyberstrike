// Nom : Étudiant
// Numéro étudiant : 000000
// Cours : INF1083
// Devoir : 03
// Date : 2026-10-04
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
