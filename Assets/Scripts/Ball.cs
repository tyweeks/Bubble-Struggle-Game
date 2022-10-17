using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }
}
