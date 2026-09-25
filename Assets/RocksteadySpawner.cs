using UnityEngine;

public class RocksteadySpawner : EnemySpawner
{
    public GameObject rocksteadyPrefab;

    public override Enemy SpawnEnemy(Vector3 position)
    {
        GameObject go = Instantiate(rocksteadyPrefab, position, Quaternion.identity);
        return go.GetComponent<Enemy>();
    }
}