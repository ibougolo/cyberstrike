// Nom : Étudiant
// Labo 1 - Profil étudiant

Console.Write("Entrez votre prénom : ");
string firstName = Console.ReadLine();

Console.Write("Entrez votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez votre programme d'études : ");
string program = Console.ReadLine();

Console.Write("Entrez votre ville : ");
string city = Console.ReadLine();

Console.Write("Combien d'heures d'étude par semaine? ");
double weeklyHours = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("----- PROFIL ÉTUDIANT -----");
Console.WriteLine($"Nom : {firstName}");
Console.WriteLine($"Âge : {age}");
Console.WriteLine($"Programme : {program}");
Console.WriteLine($"Ville : {city}");
Console.WriteLine($"Heures d'étude par semaine : {weeklyHours}");
Console.WriteLine($"{firstName} aura {age + 1} ans l'année prochaine.");
Console.WriteLine($"{firstName} étudie environ {weeklyHours * 4} heures par mois.");
