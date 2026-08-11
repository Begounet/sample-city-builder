# Unity Getting Started

This repository now includes a Unity project scaffold for the City Life Prototype.

## What is included
- `Assets/Scenes/Main.unity`: starter scene with camera, light, and root objects for game logic and world content
- `Assets/Scripts/`: core script templates for `DayNightCycle`, `BuildingPlacement`, `ResidentAI`, `ResourceManager`, `ElectricityManager`, and `RoleManager`
- `Packages/manifest.json`: Unity package manifest placeholder
- `ProjectSettings/ProjectSettings.txt`: placeholder so Unity can populate project settings when opened

## How to open the project
- Open Unity Hub and add the folder `f:\Projects\sample-city-builder` as a project
- Or use the Unity CLI if installed:
  ```powershell
  unity open f:\Projects\sample-city-builder
  ```

## Scene guidance
- Open `Assets/Scenes/Main.unity`
- The scene includes:
  - `Main Camera`
  - `Directional Light`
  - `GameManagers`
  - `World`
- After opening in Unity, attach your game systems to `GameManagers` and build the city layout under `World`.

## Next steps
1. Open the scene in Unity
2. Add the `DayNightCycle`, `ResourceManager`, and `BuildingPlacement` components to a `GameManagers` GameObject
3. Create prefabs under `Assets/Prefabs/` for houses, power plants, and commerce buildings
4. Use `Assets/Scenes/Main.unity` as the first playable scene
