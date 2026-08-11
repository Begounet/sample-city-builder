# 04 - Interface et tutoriels

## Interface utilisateur
L’interface doit rester simple et épurée, avec :
- un panneau de construction
- une zone d’information sur le bâtiment sélectionné
- une barre de ressources globales (bonheur, population, argent)

Le projet adopte UI Toolkit comme approche principale de développement d’interface runtime :
- utiliser `UIDocument` pour attacher l’UI à la scène
- construire les écrans avec UXML
- styliser avec USS
- piloter les interactions via `VisualElement`, `Button.clicked`, et des classes C# dédiées

## Style visuel
- Minimaliste
- Joyeux et coloré
- Facile à lire pour un jeune joueur

## Tutoriels progressifs
Les défis apparaissent peu à peu pour guider le joueur sans le submerger :
1. construire une maison
2. ajouter des routes
3. construire une centrale électrique
4. créer un commerce
5. équilibrer bonheur et population
