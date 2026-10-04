# Devoir 03 - Classes, Objets et Constructeurs

## Description
Application Console C# qui démontre les concepts de base des classes, objets et constructeurs.

## Contenu du projet

### Classe Etudiant (`Etudiant.cs`)
- **Propriétés** :
  - `Nom` (string) : le nom de l'étudiant
  - `Age` (int) : l'âge de l'étudiant
  - `Note` (double) : la note de l'étudiant

- **Constructeur** :
  - Initialise les trois propriétés avec les valeurs reçues en paramètre

- **Méthodes** :
  - `AfficherInformations()` : affiche les informations de l'étudiant
  - `Statut()` : retourne "Réussite" si Note >= 60, sinon "Échec"

### Programme principal (`Program.cs`)
Le programme :
1. Crée deux objets Etudiant pré-définis
   - Sophie, 18 ans, note 82 → Réussite
   - Marc, 20 ans, note 58 → Échec
2. Affiche leurs informations et statut
3. Demande à l'utilisateur de créer un troisième étudiant
4. Affiche les informations et le statut du nouvel étudiant

## Exécution

```bash
cd labs/Devoir03_Classes_Constructeurs
dotnet run
```

### Exemple d'exécution

```
Nom : Sophie
Âge : 18
Note : 82
Statut de Sophie : Réussite

Nom : Marc
Âge : 20
Note : 58
Statut de Marc : Échec

----- Créer un nouvel étudiant -----
Nom : Alex
Âge : 19
Note : 75

Nom : Alex
Âge : 19
Note : 75
Statut : Réussite
```

## Concepts clés

- **Classe** : un modèle qui décrit les données et les comportements
- **Objet** : une instance concrète créée à partir d'une classe
- **Propriété** : une valeur conservée dans un objet
- **Constructeur** : une méthode spéciale appelée automatiquement avec `new`
- **Mot-clé `new`** : crée une nouvelle instance d'une classe
