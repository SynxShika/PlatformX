using UnityEngine;

public class PlayerController : Character, IDamageable
{
    public float jumpForce = 8f;
    Rigidbody2D rb;
    bool grounded;

    void Awake() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && grounded)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    void OnCollisionEnter2D(Collision2D c) => grounded = true;
    void OnCollisionExit2D(Collision2D c) => grounded = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
            TakeDamage();
    }

    public void TakeDamage() => Die();

    public override void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}