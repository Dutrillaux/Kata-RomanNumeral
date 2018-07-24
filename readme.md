**Kata - Chiffres Romains**

Ce Kata a pour objectif de mettre en œuvre la pratique du TDD (Test Driven Development : développement piloté par les tests), 
tout en implémentant une méthode qui convertit de chiffres arabes en nombres romains.

Pour mémoire :
- Test Driven Development : https://fr.wikipedia.org/wiki/Test_driven_development
- Chiffres romains : https://fr.wikipedia.org/wiki/Num%C3%A9ration_romaine


**Protocole**
 
* Récupération le code source
 
* Mise en place de l'environnement de développement

    **Setup - Visual Studio 2017**
    - Ouvrez le répertoire Dotnet/Start (ou Dotnet.Core/Start)
    - Ouvrez la solution RomanNumeralConsole.sln
    - Buildez la solution
    - Ouvrez le fichier RomanNumeralConverterTest.cs  
    - Lancez les tests

    **Setup - IntelliJ**
    - Ouvrez le répertoire Java/Start
    - Dans l'onglet Maven, faites un ré-import du projet
    - Sélectionnez la configuration Junit Test Roman Numerals
    - Lancez la configuration Junit Test Roman Numerals

<!--- 
    **Setup - Visual Studio Code**
    - Ouvrez le répertoire Dotnet/Start (ou Dotnet.Core/Start)
    - Ouvrez la solution RomanNumeralConsole.sln
    - Installez les plugins suivants :
        - vscode-nuget-package-manager
--->

* Méthodologie proposée

Il est proposé de suivre le plan de test dans l'ordre suivant :

I. Premier tour 
- Convertir le chiffre 1
- Convertir le chiffre 2
- Convertir le chiffre 3
- Convertir le chiffre 4

Refactoring.

II. Deuxième tour  
- Convertir le chiffre 5
- Convertir le chiffre 7
- Convertir le chiffre 9
- Convertir le nombre 10
- Convertir le nombre 17

Refactoring.

III. Troisième tour
- Convertir le nombre 30
- Convertir le nombre 38
- Convertir le nombre 479
- Convertir le nombre 3999

Refactoring.

