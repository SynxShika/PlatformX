using UnityEngine;

public class Rocksteady : Enemy
{
    void Awake()
    {
        moveSpeed = 4f;
        patrolRange = 3f;
    }

    public override void Attack()
    {
        Debug.Log("Rocksteady charges!");
    }
}