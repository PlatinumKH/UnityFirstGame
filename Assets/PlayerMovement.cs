using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {

	}

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	
	// We marked this as "FixedUpdate" because
    // we are using it to mess with physics
	void FixedUpdate () {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
