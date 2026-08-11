
using Unity.Entities;

namespace CityBuilder.ECS
{
    public partial struct CitySimulationSystem : ISystem
    {
        public void OnCreate(ref SystemState state) { }

        public void OnDestroy(ref SystemState state) { }

        public void OnUpdate(ref SystemState state)
        {
            float deltaTime = SystemAPI.Time.DeltaTime;

            foreach (var resource in SystemAPI.Query<RefRW<ResourceComponent>>())
            {
                // RefRW exposes ValueRW for writable access and ValueRO for readonly access.
                resource.ValueRW.Stock += (int)(resource.ValueRO.Production * deltaTime);
            }
        }
    }
}
