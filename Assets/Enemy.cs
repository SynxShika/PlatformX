using UnityEngine;

public abstract class Enemy : Character
{
    public float patrolRange = 2f;
    protected Vector3 start;
    protected int dir = 1;

    protected virtual void Start()
    {
        start = transform.position;
    }

    protected virtual void Update()
    {
        transform.Translate(Vector2.right * dir * moveSpeed * Time.deltaTime);
        if (Mathf.Abs(transform.position.x - start.x) >= patrolRange)
            dir *= -1;
    }

    public override void Die()
    {
        gameObject.SetActive(false);
    }

    public abstract void Attack();
}