using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Chain.IsFired = false;
    }
}
