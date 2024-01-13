# Description du projet
Le projet est une application web qui permet le gestion d’une université
Elle assure des fonctionnalités suivant:
* Les opérations CRUD sur les cours
* Les opérations CRUD sur les élèves
* Affectation des élèves au cours
* Affectation des formateur au cours

INFO:
Opérations CRUD: L'affichage, l’insertion, a mise à jour et la suppression

# L’architecture de l’application
C’est une application Client-Serveur.
Le serveur expose les fonctionnalités du CRUD sur des Entités/ Tables sous forme d’un REST API.
L’application client consomme le REST API est utilise ses fonctionnalités pour faire fonctionner les interfaces utilisateur.

# Partie technologies:
L'application sera réalisée en C# .NET:
Pour l’application serveur, on utilisera ASP .NET pour créer le REST API et Entity Framework pour communiquer avec la base de données.
Pour l'application côté client elle sera réalisée en utilisant Blazor

# Architecture du projet
L’application est en fait répartie en 3 sous project:

* Project Entities
S'occupe de la partie création des entités/modles et la couche Data et communication avec la base de données, qui serra implémenté en utilisant Entity Framework
* Project University Serveur
S'occupe de la partie création du REST API et controllers
* Project University Client
S'occupe de la partie Interface utilisateur réalisé par Blazor et la consommation du REST API

Remarque: La structure de la solution reflet cet architecture

# Partie conception de la base de donnée
On a prévue 4 tables:
* Students: contient les information des étudiants
* Teachers: contient les informations des formateurs/ professeures
* Courses: contient les informations des cours
* Enrôlements: contient les informations des inscription des étudiants au cours et les notes

En vois très bien qu'il y a:
* une relation one to many entre Teachers et Courses
* une relation many to one entre Enroulements et Students
* une relation many to one entre Enroulements et Courses

# les contributeurs
LAGZAL Mohamed <mlagzal.sayhi@gmail.com>

