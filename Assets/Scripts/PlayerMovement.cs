using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 10000f;
    public float sidewaysForce = 500f;

    // FixedUpdate er betra fyrir physics systemið og loopar við hvern ramma
    void FixedUpdate()
    {
        //Bæti forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        // Athugar hvaða lykil var ýtt á
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Athugar hvort leikmaðurinn fór of neðarlega
        if (rb.position.y < -1f)
        {
            // restartar leiknum
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
