using UnityEngine;

public class RocketController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10f;

    private void Update()
    {
        float velY = rb.velocity.y;
        float ang = Mathf.Atan2(velY, 10) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, ang);

        if (Input.GetMouseButtonDown(0) | Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(0, jumpForce, 0);
            
        }
    }
}
