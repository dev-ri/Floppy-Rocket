using UnityEngine;

public class TriangleMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float destroyDely = 10f;
    private void Start()
    {
        rb.velocity = new Vector2(-speed, 0);
        Destroy(gameObject, destroyDely);
    }
}
