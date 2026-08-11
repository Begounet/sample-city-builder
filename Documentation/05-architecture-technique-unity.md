# 05 - Architecture technique Unity

## Structure de projet recommandée
Assets/
  Scripts/
    Core/
    ECS/
    Buildings/
    Population/
    Resources/
    UI/
    Tutorial/
  Prefabs/
Scenes/

## ECS et DOTS
- La simulation du cœur du jeu doit privilégier Unity ECS / DOTS.
- Utiliser `com.unity.entities` pour les composants métiers et les systèmes de simulation.
- Représenter les entités de jeu avec des `IComponentData` et les traiter dans des `SystemBase`.
- Les objets OOP restent possibles pour les helpers et le tooling, mais la boucle runtime principale s’appuie sur ECS pour de meilleures performances.

## Composants principaux
- DayNightCycle : gestion du cycle jour/nuit
- ResidentAI : déplacement et rôles des habitants
- BuildingPlacement : placement libre des bâtiments
- ResourceManager : gestion des ressources globales
- ElectricityManager : distribution de l’électricité
- RoleManager : attribution ingénieurs / commerçants / oisifs

## Objectifs techniques du prototype
- performance correcte sur Windows
- code simple et maintenable
- intégration facile avec des assets gratuits
