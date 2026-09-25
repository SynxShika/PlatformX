using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Header("Factory - one spawner per spawn point, matched by index")]
    public EnemySpawner[] spawners;
    public Transform[] spawnPoints;

    private DateTime sessionStart;

    public override void Awake()
    {
        base.Awake(); 
        sessionStart = DateTime.Now;
        Debug.Log("Game session started @ " + sessionStart);
    }

    void Start()
    {
        int count = Mathf.Min(spawners.Length, spawnPoints.Length);
        for (int i = 0; i < count; i++)
        {
            Enemy enemy = spawners[i].SpawnEnemy(spawnPoints[i].position);
            enemy.Attack();
        }
    }

    void OnApplicationQuit()
    {
        TimeSpan duration = DateTime.Now - sessionStart;
        Debug.Log("Game session lasted: " + duration);
    }
}