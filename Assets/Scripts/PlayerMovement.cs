using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Used to reference the RigidBody component as "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
        
    // We use FixedUpdate when manipulating psysics in Unity
    void FixedUpdate()
    {
        // Adds forward force to the player
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
