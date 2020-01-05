using UnityEngine;
public class RocketController : MonoBehaviour
{
    public Rigidbody2D rb;
    public scoreCounter scoreCounter;
    public gameController gameController;
    public cameraSheck cameraSheck;
    public GameObject crushEffect;
    public float jumpForce = 10f;
    public float gravityIncrise;

    private void Start()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    private void Update()
    {
        float velY = rb.velocity.y;
        float ang = Mathf.Atan2(velY, 10) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, ang);

        if (Input.GetMouseButtonDown(0) | Input.GetButtonDown("Jump"))
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;

            rb.gravityScale = 1;
            rb.velocity = new Vector3(0, jumpForce, 0);
        }
        if(velY < 0)
        {
            rb.gravityScale += gravityIncrise;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "score")
        {
            scoreCounter.scoreCount();
        }
        else if(collision.tag == "enemy")
        {
            StartCoroutine(gameController.RocketDie());
            cameraSheck.Shake();
            Instantiate(crushEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if(collision.tag == "Ground")
        {
            StartCoroutine(gameController.RocketDie());
            Destroy(gameObject);
        }
    }
}
