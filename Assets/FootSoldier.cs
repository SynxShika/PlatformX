using UnityEngine;

public class FootSoldier : Enemy
{
    void Awake()
    {
        moveSpeed = 2f;
        patrolRange = 2f;
    }

    public override void Attack()
    {
        Debug.Log("Foot Soldier slashes!");
    }
}