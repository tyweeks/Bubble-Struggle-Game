using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public float speed = 4f;

    public Rigidbody2D rb;

    private float movement;

    // Update is called once per frame
    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.right * movement * Time.fixedDeltaTime);
    }
}
