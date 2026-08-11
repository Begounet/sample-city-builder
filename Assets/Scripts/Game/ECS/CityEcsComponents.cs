using Unity.Entities;

namespace CityBuilder.ECS
{
    public struct BuildingComponent : IComponentData
    {
        public int BuildingType;
        public int ElectricityRequired;
    }

    public struct ResourceComponent : IComponentData
    {
        public int Stock;
        public int Production;
    }

    public struct ResidentComponent : IComponentData
    {
        public int HomeBuildingId;
        public int WorkBuildingId;
    }
}
