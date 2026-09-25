using UnityEngine;

public class FootSoldierSpawner : EnemySpawner
{
    public GameObject footSoldierPrefab;

    public override Enemy SpawnEnemy(Vector3 position)
    {
        GameObject go = Instantiate(footSoldierPrefab, position, Quaternion.identity);
        return go.GetComponent<Enemy>();
    }
}