using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 5f;

    public float MoveSpeed => moveSpeed;

    public abstract void Die();
}