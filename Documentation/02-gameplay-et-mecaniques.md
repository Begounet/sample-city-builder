# 02 - Gameplay et mécaniques

## Loop principal
Le joueur construit des bâtiments, fait vivre la ville, puis ajuste ses choix pour maintenir un équilibre entre bonheur, population et revenus.

## Construction

### Interface de construction
Accès via panneau d'outils aux 4 types de bâtiments (maison, centrale, commerce, route). Le placement est libre sans grille imposée.

### Système routier détaillé
- **Sélection** : Le joueur sélectionne le type "route" dans l'interface de construction des bâtiments.
- **Traçage** : À partir de la sélection, il peut cliquer sur le terrain ou une route existante pour commencer à tracer la nouvelle route.
- **Courbe Bézier automatique** : Une fois deux points placés (début et fin), la route suit automatiquement une courbe de Bézier ajustée pour un résultat fluide et esthétique.
- **Fusion automatique** : Si une route traverse ou rejoint une route existante, celle-ci est fusionnée automatiquement avec le réseau routier existant. Cela génère un ensemble de routes continues et connectées dans toute la ville.

## Cycle jour/nuit
- 24h en jeu = 10 minutes en temps réel
- La journée active les déplacements et les revenus
- La nuit ramène les habitants chez eux

## Ressources principales
- Population
- Bonheur
- Argent
- Électricité
- Logement

## Règles économiques de base
- Une maison génère 2 habitants
- Un commerce génère +1 € par heure virtuelle si l’électricité est disponible
- Une maison sans électricité fait baisser le bonheur de 1 par jour
- Un commerce proche d’une maison (+/- 500m) augmente le bonheur de cette maison de 1 par jour
