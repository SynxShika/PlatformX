using UnityEngine;

public class EnemyPatrol : Character
{
    public float range = 2f;
    Vector3 start;
    int dir = 1;

    void Start() => start = transform.position;

    void Update()
    {
        transform.Translate(Vector2.right * dir * moveSpeed * Time.deltaTime);
        if (Mathf.Abs(transform.position.x - start.x) >= range)
            dir *= -1;
    }

    public override void Die()
    {
        gameObject.SetActive(false);
    }
}