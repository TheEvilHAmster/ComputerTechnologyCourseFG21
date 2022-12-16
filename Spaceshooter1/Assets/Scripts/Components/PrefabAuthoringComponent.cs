using Unity.Entities;

[GenerateAuthoringComponent]
public struct PrefabsAuthoringComponent : IComponentData
{
    public Entity AsteroidPrefab;
    public Entity BulletPrefab;
    public Entity PlayerPrefab;
}