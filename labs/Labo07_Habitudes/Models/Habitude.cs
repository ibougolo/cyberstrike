// Nom : Ahmet Ibrahima Diene
// Numéro étudiant : 300157381
// Cours : INF1083 - Laboratoire 07
// Description : Modèle d'une habitude quotidienne

namespace Labo07_Habitudes.Models;

public class Habitude
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public bool EstFaite { get; set; }
}
