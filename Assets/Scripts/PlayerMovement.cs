using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {

    }

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "FixedUpdate" because
    // we are using it to mess with physics
    void FixedUpdate()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal") * Time.deltaTime);
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rb.AddForce(sidewaysForce * Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rb.AddForce(sidewaysForce * Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
