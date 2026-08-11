# 05 - Architecture technique Unity

## Structure de projet recommandée
Assets/
  Scripts/
    Core/
    Buildings/
    Population/
    Resources/
    UI/
    Tutorial/
  Prefabs/
Scenes/

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
