// Nom : Étudiant
// Numéro étudiant : 000000
// Cours : INF1083
// Devoir : 03
// Date : 2026-10-04
// Description : Classes, objets et constructeurs en C#

// Test 1 : Sophie, 18 ans, note 82
Etudiant etudiant1 = new Etudiant("Sophie", 18, 82);
etudiant1.AfficherInformations();
Console.WriteLine($"Statut de {etudiant1.Nom} : {etudiant1.Statut()}");
Console.WriteLine();

// Test 2 : Marc, 20 ans, note 58
Etudiant etudiant2 = new Etudiant("Marc", 20, 58);
etudiant2.AfficherInformations();
Console.WriteLine($"Statut de {etudiant2.Nom} : {etudiant2.Statut()}");
Console.WriteLine();

// Test 3 : Créer un troisième étudiant avec valeurs saisies
Console.WriteLine("----- Créer un nouvel étudiant -----");
Console.Write("Nom : ");
string nom = Console.ReadLine() ?? "";

Console.Write("Âge : ");
int age = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Note : ");
double note = double.Parse(Console.ReadLine() ?? "0");

Etudiant etudiant3 = new Etudiant(nom, age, note);
Console.WriteLine();
etudiant3.AfficherInformations();
Console.WriteLine($"Statut : {etudiant3.Statut()}");
