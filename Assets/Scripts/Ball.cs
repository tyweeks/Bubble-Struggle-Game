using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;

    public GameObject nextBall;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if (nextBall != null)
        {
            GameObject rightBall = Instantiate(nextBall, rb.position + Vector2.right / 4, Quaternion.identity);
            GameObject leftBall = Instantiate(nextBall, rb.position + Vector2.left / 4, Quaternion.identity);

            rightBall.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
            leftBall.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);

        }

        Destroy(gameObject);
    }
}
