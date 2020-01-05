using UnityEngine;
public class RocketController : MonoBehaviour
{
    public Rigidbody2D rb;
    public scoreCounter scoreCounter;
    public timeManager timeManager;
    public GameObject crushEffect;
    public float jumpForce = 10f;
    public float gravityIncrise;
    private void Update()
    {
        float velY = rb.velocity.y;
        float ang = Mathf.Atan2(velY, 10) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, ang);

        if (Input.GetMouseButtonDown(0) | Input.GetButtonDown("Jump"))
        {
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
            timeManager.slowDown();
            Instantiate(crushEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
